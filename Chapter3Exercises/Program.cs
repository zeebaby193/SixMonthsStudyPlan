
Console.Write("Input your score: ");
string input = Console.ReadLine()!;

if (int.TryParse(input, out int score))
{
    //arithmetic expression
    double percentage = (score / 100.0) * 100;

    //logical + relational expression
    bool passed = score >= 50 && score <= 100;

    //ternary expression
    string grade = score >= 70 ? "Distinction" : score >= 50 ? "Credit" : score >= 40 ? "Pass" : "Fail";

    //null coalescing expression
    string remark = (score == 100) ? "Perfect!" : null!;
    remark ??= "Keep pushing!";

    Console.WriteLine($"Score: {score}"); 
    Console.WriteLine($"Passed: {passed}");
    Console.WriteLine($"Grade: {grade}");
    Console.WriteLine($"Remark: {remark}");
}
else
{
    Console.WriteLine("Invalid score entered.");
}

int a = 15;
int b = 4;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine((double)a / b);
Console.WriteLine(a % b);
Console.WriteLine(a + b * 2 - 10/2);
Console.WriteLine((a + b) * 2 - 10/2);

int num = -4;
string result = (num % 2 == 0) ? "Even" : "Odd";
Console.WriteLine($"{num} is {result}");

