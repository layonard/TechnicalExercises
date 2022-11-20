using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercises
{
    /**
    You are working on an authentication system and there is a set of rules the users have to follow when picking a new password:

    1. It has to be at least 16 characters long.
    2. The password cannot contain the word "password". This rule is not case-sensitive.
    3. The same character cannot be used more than 4 times. This rule is case-sensitive, "a" and "A" are different characters.
    4. The password has to contain at least one uppercase and one lowercase letter.
    5. The password has to contain at least one of the following special characters "*","#","@".

    Write a function that takes in a password and returns a collection of any rule numbers that are not met.

    password1 = "Strongpwd9999#abc"             ==> []
    password2 = "Less10#"                       ==> [1]
    password3 = "Password@"                     ==> [1,2]
    password4 = "#PassWord011111112222223x"     ==> [2,3]
    password5 = "password#1111111"              ==> [2,3,4]
    password6 = "aaaapassword$$"                ==> [1,2,3,4,5]
    password7 = "LESS10#"                       ==> [1,4]


    All test cases:

    validate(password1) ==> []
    validate(password2) ==> [1]
    validate(password3) ==> [1,2]
    validate(password4) ==> [2,3]
    validate(password5) ==> [2,3,4]
    validate(password6) ==> [1,2,3,4,5]
    validate(password7) ==> [1,4]


    Complexity variables:

    N = length of the password
    **/
    public sealed class PasswordChecker
    {
        private List<string> _passwords;
        public PasswordChecker()
        {
            _passwords = new List<string>
            {
                { "Strongpwd9999#abc" },
                { "Less10#" },
                { "Password@" },
                { "#PassWord011111112222223x" },
                { "password#1111111" },
                { "aaaapassword$" },
                { "LESS10#" }
            };
        }

        public void Solution()
        {
            foreach(string password in _passwords)
            {
                Console.WriteLine($"Password: {password}");
                Validate(password);
                Console.WriteLine("-------------");
            }
        }

        private void Validate(string password)
        {
            var result = "[";
            var results = new List<string>
            {
                { Rule1(password) },
                { Rule2(password) },
                { Rule3(password) },
                { Rule4(password) },
                { Rule5(password) }
            };
            result += string.Join(",", results.Where(p => !String.IsNullOrEmpty(p)).ToArray());
            result += "]";
            Console.WriteLine(result);
        }
        private string Rule1(string password)
        {
            return password.Length < 16 ? "1" : "";
        }

        private string Rule2(string password)
        {
            return password.ToLower().Contains("password") ? "2" : "";
        }

        private string Rule3(string password)
        {
            var checker = new Dictionary<char, int>();
            foreach (var character in password)
            {
                if (!char.IsLetter(character))
                    continue;
                if (checker.ContainsKey(character))
                {
                    checker[character]++;
                    if (checker[character] == 4)
                        return "3";
                }
                else
                    checker.Add(character, 1);
            }
            return "";
        }

        private string Rule4(string password)
        {
            var pattern = @"(([A-Z])+[a-z]+)|([a-z]+[A-Z])+";
            Regex rg = new Regex(pattern);
            return rg.Matches(password).Count < 1 ? "4" : "";
        }

        private string Rule5(string password)
        {
            var pattern = @"[*#@]";
            Regex rg = new Regex(pattern);
            return rg.Matches(password).Count < 1 ? "5" : "";
        }
    }
}
