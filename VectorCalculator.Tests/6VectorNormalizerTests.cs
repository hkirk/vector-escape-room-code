namespace VectorCalculator.Tests;

using NUnit.Framework;
using System;

[TestFixture]
public class VectorNormalizerTests
{
    // Write your own tests here.
    // The passkey will only be revealed if they cover:
    // 1. A happy path test (e.g., normalizing a non-zero vector).
    // 2. An edge case test (e.g., attempting to normalize a zero vector).

    [Test]
    public void Normalize_NonZeroVector_ReturnsUnitVector()
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
        var happyPathTested = Engine.HappyPathTested(testMethodsNames, "normalize_nonzero");
        var edgeCaseTested = Engine.EdgeCaseTested(testMethodsNames, "normalize_zero");
        var allTestsHaveAssertions = Engine.CheckMethodsForAsserts(thisType, 6);
        var str = File.ReadAllText("Data/File6");

        if (happyPathTested && edgeCaseTested && allTestsPasses && allTestsHaveAssertions)
        {
            TestContext.Error.WriteLine($@"
___  _   _ _____ _____ _   _  ____
/ _ \| \ | |_   _|_   _| | | |/ ___|
/ /_\ \  \| | | |   | | | | | | |
|  _  | . ` | | |   | | | |_| | |___
|_| |_|_|\_| |_|   |_|  \___/ \____|
All required tests passed! Your passkey??: {str}, maybe you need to look else were for the rest of the passcode
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
- Write a test for the HAPPY PATH (e.g., normalizing a non-zero vector).
  Example name: Normalize_NonZeroVector_ReturnsUnitVector
- Write a test for an EDGE CASE (e.g., attempting to normalize a zero vector).
  Example name: Normalize_ZeroVector_ThrowsException";
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
