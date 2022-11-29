namespace Exercises;
/*
 Given a string s containing just the characters '(', ')', '{', '}', '[', and ']', determine if the input string is valid.
 An input string is valid if:
    0. Open brackets must be closed by the same type of brackets.
    0. Open brackets must be closed in the correct order.

Constraints:
    1 <= s.lenght <= 104
    s consists of parentheses only '()[]{}'

Example 1:
    Input: s = "()"
    Output: valid

Example 2:
    Input: s = "()[]{}"
    Output: valid

Example 3:
    Input: s = "(]"
    Output: invalid

Example 4:
    Input: s = "([)]"
    Output: invalid

Example 5:
    Input: s = "{[]}"
    Output: valid
 */
public class ValidParentheses
{
    private readonly Dictionary<char, char> _openCloseRelation;

    public ValidParentheses()
    {
        _openCloseRelation= new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };
    }
    public string Solution(string input)
    {
        return IsValid(input) ? "valid" : "invalid";
    }

    private bool IsValid(string s)
    {
        var parentheses = new Stack<char>();

        foreach (char c in s)
        {
            if (IsStartParentheses(c))
            {
                parentheses.Push(c);
                continue;
            }

            if (parentheses.IsEmpty())
                return false;

            var open = parentheses.Pop();
            if(_openCloseRelation[open] != c) 
                return false;
        }

        return parentheses.IsEmpty();
    }

    private bool IsStartParentheses(char c)
    {
        return c == '(' || c == '[' || c == '{';
    }

}

static class StackExtensions
{
    public static bool IsEmpty(this Stack<char> stack)
    {
        return stack.Count == 0;
    }
}