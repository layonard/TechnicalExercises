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
    public string Solution(string input)
    {
        return IsValid(input) ? "valid" : "invalid";
    }

    private bool IsValid(string s)
    {
        return true;
    }
}
