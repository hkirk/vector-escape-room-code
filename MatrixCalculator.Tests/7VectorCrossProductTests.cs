namespace MatrixCalculator.Tests;
using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

[TestFixture]
public class VectorCrossProductTests
{
    // Write your own tests here.
    // The passkey will only be revealed if they cover:
    // 1. A happy path test (e.g., calculating the cross product of two 3D vectors).
    // 2. An edge case test (e.g., attempting to calculate the cross product of non-3D vectors).

    [Test]
    public void Cross_3DVectors_ReturnsCorrectVector()
    {
        Assert.That(true, Is.EqualTo(false));
    }

    /*********** Ignore this below, this is here for the game ***************/
    /*********** And _no_ cheating :) ************/
    [OneTimeTearDown]
    public void CheckTestsAndPrintPasskey()
    {
        Type thisType = this.GetType();
        bool allTestsPasses = !(TestContext.CurrentContext.Result.FailCount > 0);

        var testMethodsNames = Engine.TestMethodsNames(thisType);
        var happyPathTested = Engine.HappyPathTested(testMethodsNames, "cross_3d");
        var edgeCaseTested = Engine.EdgeCaseTested(testMethodsNames, "cross_non3d");
        var allTestsHaveAssertions = Engine.CheckMethodsForAsserts(thisType);

        // Count the total number of tests in the entire project
        var assembly = Assembly.GetExecutingAssembly();
        var testClasses = assembly.GetTypes()
            .Where(t => t.GetCustomAttributes(typeof(TestFixtureAttribute), false).Length > 0);
        int totalTests = testClasses.Sum(t => t.GetMethods()
            .Count(m => m.GetCustomAttributes(typeof(TestAttribute), false).Length > 0));
        

        if (happyPathTested && edgeCaseTested && allTestsPasses && allTestsHaveAssertions)
        {
            Console.WriteLine($@"
___  _   _ _____ _____ _   _  ____
/ _ \| \ | |_   _|_   _| | | |/ ___|
/ /_\ \  \| | | |   | | | | | | |
|  _  | . ` | | |   | | | |_| | |___
|_| |_|_|\_| |_|   |_|  \___/ \____|

🎉 ALL CHALLENGES COMPLETED! 🎉
You have written a total of {totalTests} tests in this project.
            ");
        }
        else
        {
            var errorMessage = @"
⚠️  MISSING TESTS!  ⚠️
To unlock the final challenge, you must write:";
            if (!(happyPathTested && edgeCaseTested))
            {
                errorMessage += @"
- Write a test for the HAPPY PATH (e.g., calculating the cross product of two 3D vectors).
  Example name: Cross_3DVectors_ReturnsCorrectVector
- Write a test for an EDGE CASE (e.g., attempting to calculate the cross product of non-3D vectors).
  Example name: Cross_Non3DVectors_ThrowsException
";
            }
            if (!allTestsHaveAssertions)
            {
                errorMessage += @"
- Ensure ALL your test methods include at least one assertion Assert.That.
";
            }
            if (!allTestsPasses)
            {
                errorMessage += @"
- Ensure ALL your test methods pass.
";
            }
            Console.WriteLine(errorMessage);
        }
    }
}
