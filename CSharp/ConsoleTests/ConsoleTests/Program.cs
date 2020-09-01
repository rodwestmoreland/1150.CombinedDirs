using System;

class Perl
{
    int _a;
    int _b;

    public Perl(int a, int b)
    {
        _a = a;
        _b = b;
    }
    public override string ToString()
    {
        return $" {_a}, {_b}";
    }

}

class Program
{
    static void Main()
    {
        Perl perl = new Perl(1, 2);
        Console.WriteLine(perl);
    }
}