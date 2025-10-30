namespace VectorCalculator.Tests;

using NUnit.Framework;
using System;

[TestFixture]
public class VectorSubtractTests
{
    // Write your own tests here.
    // The passkey will only be revealed if they cover:
    // 1. A happy path test (e.g., subtracting two valid vectors).
    // 2. An edge case test (e.g., vectors of different sizes).

    [Test]
    public void Subtract_TwoVectors_ReturnCorrectVector()
    {
        Assert.That(true, Is.EqualTo(false));
    }

    /*********** Ignore this below, this is here for the game ***************/
    /*********** And _no_ cheating :) ************/
    [OneTimeTearDown]
    public void CheckTestsAndPrintPasskey()
    {
        Type thisType = GetType();
        bool allTestsPasses = !(TestContext.CurrentContext.Result.FailCount > 0);

        var testMethodsNames = Engine.TestMethodsNames(thisType);
        var happyPathTested = Engine.HappyPathTested(testMethodsNames, "subtract_twovector");
        var edgeCaseTested = Engine.EdgeCaseTested(testMethodsNames, "differentsizes");
        var allTestsHaveAssertions = Engine.CheckMethodsForAsserts(thisType, 2);
        var str = File.ReadAllText("Data/File2");

        if (happyPathTested && edgeCaseTested && allTestsPasses && allTestsHaveAssertions)
        {
            TestContext.Error.WriteLine($@"
___  _   _ _____ _____ _   _  ____
/ _ \| \ | |_   _|_   _| | | |/ ___|
/ /_\ \  \| | | |   | | | | | | |
|  _  | . ` | | |   | | | |_| | |___
|_| |_|_|\_| |_|   |_|  \___/ \____|
All required tests passed! Your passkey: {str}
            ");
        }
        else
        {
            var errorMessage = @"
⚠️  MISSING TESTS!  ⚠️
To unlock the next challenge, you must write:";
            if (!(happyPathTested && edgeCaseTested))
            {
                errorMessage += @"
- Write a test for the HAPPY PATH (e.g., subtracting two valid vectors).
  Example name: Subtract_TwoVectors_ReturnsCorrectDifference
- Write a test for an EDGE CASE (e.g., vectors of different sizes).
  Example name: Subtract_VectorsOfDifferentSizes_ThrowsException
";
            }
            if (!allTestsHaveAssertions)
            {
                errorMessage += @"- Ensure ALL your test methods include at least one assertion Assert.That.
";
            }
            if (!allTestsPasses)
            {
                errorMessage += @"- Ensure ALL your test methods pass.
";
            }
            TestContext.Error.WriteLine(errorMessage);
        }
    }
}
