namespace MatrixCalculator.Tests;

using NUnit.Framework;
using System;

[TestFixture]
public class VectorDotProductTests
{
    // Write your own tests here.
    // The passkey will only be revealed if they cover:
    // 1. A happy path test (e.g., calculating the dot product of two non-zero vectors).
    // 2. An edge case test (e.g., calculating the dot product of orthogonal vectors).

    [Test]
    public void Dot_NonZeroVectors_ReturnsCorrectValue()
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
        var happyPathTested = Engine.HappyPathTested(testMethodsNames, "dot_nonzero");
        var edgeCaseTested = Engine.EdgeCaseTested(testMethodsNames, "dot_orthogonal");
        var allTestsHaveAssertions = Engine.CheckMethodsForAsserts(thisType);
        var file5 = File.ReadAllText("Data/File5");

        if (happyPathTested && edgeCaseTested && allTestsPasses && allTestsHaveAssertions)
        {
            Console.WriteLine($@"
___  _   _ _____ _____ _   _  ____
/ _ \| \ | |_   _|_   _| | | |/ ___|
/ /_\ \  \| | | |   | | | | | | |
|  _  | . ` | | |   | | | |_| | |___
|_| |_|_|\_| |_|   |_|  \___/ \____|
All required tests passed! Your passkey??: .........-{file5}-........., maybe you need to look else were for the rest of the passcode
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
- Write a test for the HAPPY PATH (e.g., calculating the dot product of two non-zero vectors).
  Example name: Dot_NonZeroVectors_ReturnsCorrectValue
- Write a test for an EDGE CASE (e.g., calculating the dot product of orthogonal vectors).
  Example name: Dot_OrthogonalVectors_ReturnsZero
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
