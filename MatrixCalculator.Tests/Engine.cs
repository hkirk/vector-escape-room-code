using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MatrixCalculator.Tests;

internal class Engine
{
    internal static bool CheckMethodsForAsserts(Type thisType)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(File.ReadAllText($"../../../{thisType.Name}.cs"));
        var root = syntaxTree.GetRoot();
        var classDeclaration = root.DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault(c => c.Identifier.Text == thisType.Name);

        if (classDeclaration != null)
        {
            foreach (var method in classDeclaration.Members.OfType<MethodDeclarationSyntax>())
            {
                var testAttr = method.AttributeLists
                    .SelectMany(al => al.Attributes)
                    .Any(a => a.Name.ToString() == "Test");

                if (testAttr)
                {
                    // Check if the method contains an Assert.That call
                    bool hasAssertion = method.DescendantNodes()
                        .OfType<InvocationExpressionSyntax>()
                        .Any(ies =>
                            ies.Expression is MemberAccessExpressionSyntax maes &&
                            maes.Name.Identifier.Text == "That" &&
                            maes.Expression is IdentifierNameSyntax ins &&
                            ins.Identifier.Text == "Assert");

                    if (!hasAssertion)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
    
    internal static bool EdgeCaseTested(List<string> testMethodsNames, string name)
    {
        return testMethodsNames.Any(m =>
            m.Contains(name) ||
            m.Contains("exception") ||
            m.Contains("edge"));
    }

    internal static bool HappyPathTested(List<string> testMethodsNames, string name)
    {
        return testMethodsNames.Any(m =>
            m.Contains(name) ||
            m.Contains("valid") ||
            m.Contains("happy"));
    }

    internal static List<string> TestMethodsNames(Type thisType)
    {
        var testMethodsNames = thisType.GetMethods()
            .Where(m => m.GetCustomAttributes(typeof(TestAttribute), false).Length > 0)
            .Select(m => m.Name)
            .Select(m => m.ToLower())
            .ToList();
        return testMethodsNames;
    }

}