namespace MatrixCalculator.Tests;

using NUnit.Framework;
using System;

[TestFixture]
public class VectorMagnitudeTests
{
    // Write your own tests here.
    // The passkey will only be revealed if they cover:
    // 1. A happy path test (e.g., calculating the magnitude of a non-zero vector).
    // 2. An edge case test (e.g., calculating the magnitude of a zero vector).

    [Test]
    public void Magnitude_NonZeroVector_ReturnsCorrectValue()
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
        var happyPathTested = Engine.HappyPathTested(testMethodsNames, "magnitude_nonzero");
        var edgeCaseTested = Engine.EdgeCaseTested(testMethodsNames, "magnitude_zero");
        var allTestsHaveAssertions = Engine.CheckMethodsForAsserts(thisType, 4);
        var file4 = File.ReadAllText("Data/File4");

        if (happyPathTested && edgeCaseTested && allTestsPasses && allTestsHaveAssertions)
        {
            Console.WriteLine($@"
___  _   _ _____ _____ _   _  ____
/ _ \| \ | |_   _|_   _| | | |/ ___|
/ /_\ \  \| | | |   | | | | | | |
|  _  | . ` | | |   | | | |_| | |___
|_| |_|_|\_| |_|   |_|  \___/ \____|
All required tests passed! Your passkey??: {file4}, maybe you need to look else were for the rest of the passcode
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
- Write a test for the HAPPY PATH (e.g., calculating the magnitude of a non-zero vector).
  Example name: Magnitude_NonZeroVector_ReturnsCorrectValue
- Write a test for an EDGE CASE (e.g., calculating the magnitude of a zero vector).
  Example name: Magnitude_ZeroVector_ReturnsZero
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
