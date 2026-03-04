using System;

// Ex 1: Number Comparison
Console.WriteLine("\nExercise 1: Number Comparison");

Console.WriteLine("Enter first number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 == num2)
{
	Console.WriteLine("The numbers are equal");
}
else if (num1 > num2)
{
	Console.WriteLine("The first number is greater than the second");
}
else
{
	Console.WriteLine("The first number is less than the second");
}

// Ex 2: Range Check (AND Operator)
Console.WriteLine("\nExercise 2: Range Check (AND Operator)");

Console.WriteLine("Enter a number:");
double num = Convert.ToDouble(Console.ReadLine());

if (num > 5 && num < 10)
{
	Console.WriteLine("The number is greater than 5 and less than 10");
}
else
{
	Console.WriteLine("Unknown number");
}

// Ex 3: Value Check (OR Operator)
Console.WriteLine("\nExercise 3: Value Check (OR Operator)");

Console.WriteLine("Enter a number:");
num = Convert.ToDouble(Console.ReadLine());

if (num == 5 || num == 10)
{
	Console.WriteLine("The number is either 5 or 10");
}
else
{
	Console.WriteLine("Unknown number");
}

// Ex 4: Bank Deposit with Interest
Console.WriteLine("\nExercise 4: Bank Deposit with Interest");

Console.WriteLine("Enter deposit amount:");
double deposit = Convert.ToDouble(Console.ReadLine());

double interestRate;

if (deposit < 100)
{
	interestRate = 0.05;
}
else if (deposit >= 100 && deposit <= 200)
{
	interestRate = 0.07;
}
else
{
	interestRate = 0.10;
}

double interest = deposit * interestRate;
double totalAmount = deposit + interest;

Console.WriteLine($"Deposit amount: {deposit}");
Console.WriteLine($"Interest rate: {interestRate * 100}%");
Console.WriteLine($"Interest: {interest}");
Console.WriteLine($"Total amount with interest: {totalAmount}");

// Ex 5: Bank Deposit with Interest and Bonus
Console.WriteLine("\nExercise 5: Bank Deposit with Interest and Bonus");

Console.WriteLine("Enter deposit amount:");
deposit = Convert.ToDouble(Console.ReadLine());

if (deposit < 100)
{
	interestRate = 0.05;
}
else if (deposit >= 100 && deposit <= 200)
{
	interestRate = 0.07;
}
else
{
	interestRate = 0.10;
}

interest = deposit * interestRate;
double bonus = 15;
totalAmount = deposit + interest + bonus;

Console.WriteLine($"Deposit amount: {deposit}");
Console.WriteLine($"Interest rate: {interestRate * 100}%");
Console.WriteLine($"Interest: {interest}");
Console.WriteLine($"Bonus: {bonus}");
Console.WriteLine($"Total amount with interest and bonus: {totalAmount}");

// Ex 6: Operation Name Selector
Console.WriteLine("\nExercise 6: Operation Name Selector");

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int operationNumber = Convert.ToInt32(Console.ReadLine());

switch (operationNumber)
{
	case 1:
		Console.WriteLine("Addition");
		break;
	case 2:
		Console.WriteLine("Subtraction");
		break;
	case 3:
		Console.WriteLine("Multiplication");
		break;
	default:
		Console.WriteLine("Operation is undefined");
		break;
}

// Ex 7: Operation Calculator
Console.WriteLine("\nExercise 7: Operation Calculator");

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
operationNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter first number:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number:");
num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;
string operationName = "";

switch (operationNumber)
{
	case 1:
		operationName = "Addition";
		result = num1 + num2;
		break;
	case 2:
		operationName = "Subtraction";
		result = num1 - num2;
		break;
	case 3:
		operationName = "Multiplication";
		result = num1 * num2;
		break;
	default:
		Console.WriteLine("Operation is undefined");
		return;
}

Console.WriteLine($"Operation: {operationName}");
Console.WriteLine($"{num1} and {num2} = {result}");
