#region actions

Action action = () => Console.WriteLine("Hello, World!");
Action<bool> actionWithParam = (bool flag) => Console.WriteLine($"Flag is: {flag}");
Action<int,string,bool> actionWithMultipleParams = (int number, string text, bool flag) => 
{
    Console.WriteLine($"Number: {number}, Text: {text}, Flag: {flag}");
};

action(); // Invokes the action without parameters
actionWithParam(true); // Invokes the action with a boolean parameter
actionWithMultipleParams(42, "Hello", true); // Invokes the action with multiple parameters

#endregion

#region Func
/// <summary>
/// last parameter is the return type
Func<int> getRandomNumber = () => new Random().Next(1, 100);
Func<int, int, int> add = (x, y) => x + y;
Func<string, string, string> concatenate = (a, b) => a + b;
Func<double, double, double, double> calculateArea = (length, width, height) => length * width * height;

getRandomNumber(); // Returns a random number between 1 and 100
add(5, 10); // Returns 15
concatenate("Hello, ", "World!"); // Returns "Hello, World!"
calculateArea(5.0, 10.0, 2.0); // Returns 100.0 (length * width * height)

#endregion

#region Predicate

Predicate<int> isEven = number => number % 2 == 0;
Predicate<string> isLongerThanFive = text => text.Length > 5;
Predicate<double> isPositive = number => number > 0;

isEven(4); // Returns true
isLongerThanFive("Hello, World!"); // Returns true
isPositive(3.14); // Returns true
#endregion

#region Lambda Discard Parameters
Func<int, int, int> addWithDiscard = (_, y) => y + 10; // Discarding the first parameter
Func<string, string> greet = name => $"Hello, {name}!"; // Using a single parameter
Func<double, double, double> multiply = (x, _) => x * 2; // Discarding the second parameter

addWithDiscard(5, 10); // Returns 20 (10 + 10)
greet("Alice"); // Returns "Hello, Alice!"
multiply(3.5, 0); // Returns 7.0 (3.5 * 2) 

#endregion