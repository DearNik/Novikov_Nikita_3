using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3
{
    }
public class Number
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Number(int Numerator, int Denominator)
    {
        if (Denominator == 0)
        {
            throw new DivideByZeroException("Ошибка , невезможно деление на 0");
        }
        if (Numerator == 0)
        {
            this.Numerator = 0;
            this.Denominator = 1;
        }
        else
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }
        if (Denominator < 0)
        {
            this.Numerator = -1 * this.Numerator;
            this.Denominator = -1 * this.Denominator;
        }
    }

    public static int reduce(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (b % a > 0)
            {
                var temp = b;
                b = a;
                a = temp % a;
            }
            else break;
        }
        if (a != 0 && b != 0) { return a; }
        return 0;
    }


    public override string ToString()
    {
        if (Denominator == 1)
        {
            return " " + Numerator;
        }
        else
        {
            return " " + Numerator + " / " + Denominator;
        }

    }
    public override bool Equals(object obj)
    {
        Number other = obj as Number;

        int rest = reduce(Numerator, Denominator);
        if (this.Numerator / rest == other.Numerator && this.Denominator / rest == other.Denominator)
            return true;
        else
            return false;
    }
    public override int GetHashCode()
    {
        int Code = Numerator;
        Code = 4 * Code + Denominator;
        return Code;
    }
}
    

