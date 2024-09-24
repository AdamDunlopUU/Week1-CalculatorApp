// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type the secound number");
int secoundNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secoundNumber;
Console.WriteLine("The addition of both number is {0}", result);
Console.ReadKey();