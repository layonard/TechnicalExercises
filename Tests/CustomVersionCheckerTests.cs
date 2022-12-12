using NUnit.Framework;
using Exercises;

namespace Tests;

public class CustomVersionCheckerTests
{
    CustomVersionChecker _app;
    
    [SetUp]
    public void Setup()
    {
        var _app = new CustomVersionChecker();
    }

    [Test]
    [TestCase ("2","2.0.0.0.0",0)]
    [TestCase ("2","2.0.0.0.1",-1)]
    [TestCase ("2","2.1",-1)]
    [TestCase ("2.1","2.0.1",1)]
    [TestCase ("2.10.0.1","2.1.0.10",1)]
    [TestCase ("2.0.1","1.2000.1",1)]
    public void SolutionTest(string version1, string version2, int expectedResult)
    {
        Assert.Equals(expectedResult, _app.Solution(version1, version2));
    }
}
