using static leetcode_practice_csharp.WellFormedParentheses;

// See https://aka.ms/new-console-template for more information
var output = GenerateParenthesis(2);
foreach (var x in output)
{
    Console.WriteLine(x);
}