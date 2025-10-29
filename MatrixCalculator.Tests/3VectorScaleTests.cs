namespace MatrixCalculator.Tests;
using NUnit.Framework;
using System;

[TestFixture]
public class VectorScaleTests
{
    // Write your own tests here.
    // The passkey will only be revealed if they cover:
    // 1. A happy path test (e.g., scaling a vector by a positive scalar).
    // 2. An edge case test (e.g., scaling by zero or a negative scalar).

    [Test]
    public void Scale_PositiveScalarScalar_ReturnCorrectVector()
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
        var happyPathTested = Engine.HappyPathTested(testMethodsNames, "scale_positivescalar");
        var edgeCaseTested = Engine.EdgeCaseTested(testMethodsNames, "scale_zeroscalar");
        var allTestsHaveAssertions = Engine.CheckMethodsForAsserts(thisType, 3);
        var file3 = File.ReadAllText("Data/File3");

        if (happyPathTested && edgeCaseTested && allTestsPasses && allTestsHaveAssertions)
        {
            Console.WriteLine($@"
___  _   _ _____ _____ _   _  ____
/ _ \| \ | |_   _|_   _| | | |/ ___|
/ /_\ \  \| | | |   | | | | | | |
|  _  | . ` | | |   | | | |_| | |___
|_| |_|_|\_| |_|   |_|  \___/ \____|
All required tests passed! Your passkey: {file3}
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
- Write a test for the HAPPY PATH (e.g., scaling a vector by a positive scalar).
  Example name: Scale_VectorByPositiveScalar_ReturnsCorrectVector
- Write a test for an EDGE CASE (e.g., scaling by zero or a negative scalar).
  Example name: Scale_VectorByZeroScalar_ReturnsZeroVector
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
            Console.WriteLine(errorMessage);
        }
    }
}
