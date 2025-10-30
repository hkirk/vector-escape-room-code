namespace VectorCalculator.Tests;

using NUnit.Framework;
using System;
using VectorCalculator.Lib;

[TestFixture]
public class VectorAddTests
{
    private Vector _uut;
        
    
    // Write your own tests here.
    // The passkey will only be revealed if they cover:
    // 1. A happy path test (e.g., adding two valid vectors).
    // 2. An edge case test (e.g., vectors of different sizes).
    [Test]
    public void Add_TwoVectors_ReturnCorrectVector()
    {
        Assert.That(true, Is.EqualTo(false));
    }

    [Test]
    public void Add_TwoVectors_DifferentSizes()
    {
        Vector v1 = null;
        Assert.That(() => _uut.Add(v1), Throws.TypeOf<ArgumentException>());
    }
    
    /*********** Ignore this below, this is here for the game ***************/
    /*********** And _no_ cheating :) ************/
    [OneTimeTearDown]
    public void CheckTestsAndPrintPasskey()
    {
        // Use reflection to check if the required tests exist
        Type thisType = GetType();
        bool allTestsPasses = !(TestContext.CurrentContext.Result.FailCount > 0);
        
        var testMethodsNames = Engine.TestMethodsNames(thisType);

        var happyPathTested = Engine.HappyPathTested(testMethodsNames, "add_twovector");
        var edgeCaseTested = Engine.EdgeCaseTested(testMethodsNames, "differentsizes");

        var allTestsHaveAssertions = Engine.CheckMethodsForAsserts(thisType, 1);

        var str = File.ReadAllText("Data/File1");
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
- Write a test for the HAPPY PATH (e.g., adding two valid vectors).
  Example name: Add_TwoVectors_ReturnsCorrectSum
- Write a test for an EDGE CASE (e.g., vectors of different sizes).
  Example name: Add_VectorsOfDifferentSizes_ThrowsException
";
            }
            if (!allTestsHaveAssertions)
            {
                errorMessage += @"- Ensure ALL your test methods include at least one assertion Assert.That.
";
            }

            if (!allTestsPasses)
            {
                errorMessage += @"- Ensure ALL your test methods passes.
";
            }
            TestContext.Error.WriteLine(errorMessage);
        }
    }

   
}
