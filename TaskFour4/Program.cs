using System;

Console.WriteLine("1) Sum");
int[] numbers = { 1, 7, 2, 9, 5, 1 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}
Console.WriteLine(sum);



Console.WriteLine("2) Min Max");
int[] temps = { 12, -25, 0, 20, -10, 35 };
int min = temps[0];
int max = temps[0];
for (int i = 1; i < temps.Length; i++)
{
    if (temps[i] < min)
    {
        min = temps[i];
    }
    if (temps[i] > max)
    {
        max = temps[i];
    }
}
Console.WriteLine($"{min} {max}");



Console.WriteLine("3) Reverse");
string[] words = { "apple", "banana", "cherry", "date" };
string[] reversed = new string[words.Length];
for (int i = 0; i < words.Length; i++)
{
    reversed[i] = words[words.Length - 1 - i];
}
Console.WriteLine(string.Join(" ", reversed));



Console.WriteLine("4) Even Odd");
int[] data = { 4, 7, 2, 11, 6, 9, 3, 8 };
int even = 0;
int odd = 0;
for (int i = 0; i < data.Length; i++)
{
    if (data[i] % 2 == 0)
    {
        even = even + 1;
    }
    else
    {
        odd = odd + 1;
    }
}
Console.WriteLine($"even {even} odd {odd}");



Console.WriteLine("5) Unique");
int[] raw = { 1, 1, 2, 3, 2, 5, 6, 4, 7, 5 };
var set = new System.Collections.Generic.HashSet<int>();
var list = new System.Collections.Generic.List<int>();
for (int i = 0; i < raw.Length; i++)
{
    if (set.Add(raw[i]))
    {
        list.Add(raw[i]);
    }
}
int[] unique = list.ToArray();
Console.WriteLine(string.Join(" ", unique));



Console.WriteLine("6) Rotate");
int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 2;
int n = arr.Length;
if (n == 0)
{
    // do nothing
}
else
{
    k = ((k % n) + n) % n;
    int[] rotated = new int[n];
    for (int i = 0; i < n; i++)
    {
        rotated[i] = arr[(i + k) % n];
    }
    Console.WriteLine(string.Join(" ", rotated));
}

