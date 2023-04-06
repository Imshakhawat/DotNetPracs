

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

int i = 0;


var q = from n in numbers
        select ++i;

// Note, the local variable 'i' is not incremented
// until each element is evaluated (as a side-effect):
foreach (var v in q)
{
    Console.WriteLine($"v = {v}, i = {i}");
}