Console.Write("Please enter the nth value as integer: ");
var n = Convert.ToInt32(Console.ReadLine());
var tool = new Factorial.FactorialTool();

Console.WriteLine();
Console.WriteLine($"LOOP Backwards calculation: Factorial of {n} is {tool.CalculateLoopBackward(n)}");
Console.WriteLine($"LOOP Fowards calculation: Factorial of {n} is {tool.CalculateLoopFoward(n)}");
Console.WriteLine($"RECURSION calculation: Factorial of {n} is {tool.CalculateRecursion(n)}");