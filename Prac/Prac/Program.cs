using Prac;

Delegates x = new Delegates();

x.number1 = 50;
x.number2 = 100;
x.Print(sum);

x.Print(sum2);

int sum(int x, int y)
{
    return x + y;
}

int sum2(int x, int y)
{
    return x * y;
}