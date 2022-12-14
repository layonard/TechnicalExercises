using Exercises;
using NUnit.Framework;

namespace Tests;

public class ValidParenthesesTests
{
    ValidParentheses _app; 
    [SetUp]
    public void Setup()
    {
        _app = new ValidParentheses();
    }

    [Test]
    [TestCase ("()", "valid")]
    [TestCase ("()[]{}", "valid")]
    [TestCase ("(]", "invalid")]
    [TestCase ("([)]", "invalid")]
    [TestCase ("{[]}", "valid")]
    [TestCase ("]}", "invalid")]
    public void ParenthesesTests(string input, string result)
    {
        Assert.AreEqual(result, _app.Solution(input));
    }
}
