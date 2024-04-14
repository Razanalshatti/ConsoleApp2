// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information



// C# Arrays
// challenge 1 
Console.WriteLine(" C# basics part 2: \n C# arrays: \n Challenge 1:");
string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

Console.WriteLine("Days of the week:");

foreach (string day in daysOfWeek)
{
    Console.WriteLine(day);
}


//challenge 2
Console.WriteLine("Challenge 2:");
int[] number = { 1, 2, 3, 4, 5 };
int sum = 0;
foreach (var num in number)
{
    sum += num;
}
Console.WriteLine("Sum of number = " + sum);

//task LINQ
//challenge 1
Console.WriteLine("Task LINQ: \n challenge 1:");
int[] numbers = { 1, 2, 3, 4, 5 };
var evennumbers = numbers.Where(x => x % 2 == 0);

Console.WriteLine("even numbers:");
foreach (var num in evennumbers)
{
    Console.WriteLine($"{num}");
}

Console.WriteLine("challenge 2:");
List<int> grades = new List<int> { 85, 90, 75, 88, 92 };
double averageGrade = grades.Average();
Console.WriteLine($"Average grade:{averageGrade}");




