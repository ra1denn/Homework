using System;

class ComplexNum
{
    private double realChapt;
    private double imChapt;

    public ComplexNum(double real, double im)
    {
        realChapt = real;
        imChapt = im;
    }

    public ComplexNum Add(ComplexNum other)
    {
        return new ComplexNum(realChapt + other.realChapt, imChapt + other.imChapt);    
    }

    public ComplexNum Multiply(ComplexNum other)
    {
        double real = (realChapt * other.realChapt) - (imChapt * other.imChapt);
        double im = (realChapt*other.imChapt) + (imChapt*other.realChapt);
        return new ComplexNum(real, im);
    }

    public ComplexNum Divide(ComplexNum other)
    {
        double znam = (other.realChapt * other.realChapt) + (other.imChapt * other.imChapt);
        double real = ((realChapt * other.realChapt) + (imChapt * other.imChapt)) / znam;
        double im = ((imChapt * other.realChapt) - (realChapt * other.imChapt)) / znam;
        return new ComplexNum(real, im);
    }

    public ComplexNum Stepeni(int exponent)
    {
        ComplexNum result = new ComplexNum(1, 0);
        for (int i = 0; i < exponent; i++)
        {
            result = result.Multiply(this);
        }
        return result;
    }

    public ComplexNum Square()
    {
        double modules = Module();
        double angle = Angle();
        double sqrtModules = Math.Sqrt(modules);
        double halfAngle = angle / 2;

        double real = sqrtModules * Math.Cos(halfAngle);
        double im = sqrtModules * Math.Sin(halfAngle);

        return new ComplexNum(real, im);
    }

    public double Module()
    {
        return Math.Sqrt((realChapt*realChapt) + (imChapt*imChapt));
    }

    public double Angle()
    {
        return Math.Atan2(imChapt, realChapt);
    }

    public override string ToString()
    {
        return $"{realChapt}+{imChapt}i";
    }
}

class Program
{
    static void Main()
    {
        ComplexNum complex1 = new ComplexNum(1, 1);
        ComplexNum complex2 = new ComplexNum(5, 7);

        Console.WriteLine($"Комплексное число 1: {complex1}");
        Console.WriteLine($"Комплексное число 2: {complex2}");

        ComplexNum sum = complex1.Add(complex2);
        Console.WriteLine($"Сумма: {sum}");

        ComplexNum umn = complex1.Multiply(complex2);
        Console.WriteLine($"Произведение: {umn}");

        ComplexNum del = complex1.Divide(complex2);
        Console.WriteLine($"Частное: {del}");

        ComplexNum step = complex1.Stepeni(2);
        Console.WriteLine($"Степень 2: {step}");

        ComplexNum sqrt = complex1.Square();
        Console.WriteLine($"Корень: {sqrt}");

        double modules = complex1.Module();
        Console.WriteLine($"Модуль: {modules}");

        double angle = complex1.Angle();
        Console.WriteLine($"Угол: {angle}");
    }
}