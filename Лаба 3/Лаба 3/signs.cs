using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3
{
    internal class signs
    {
        public Number Add(Number n, Number m)
        {
            int red = Number.reduce(n.Numerator * m.Denominator + m.Numerator * n.Denominator, n.Denominator * m.Denominator);
            return new Number((n.Numerator * m.Denominator + m.Numerator * n.Denominator) / red, (n.Denominator * m.Denominator) / red);

        }
        public Number Subtract(Number n, Number m)
        {
            int red = Number.reduce(n.Numerator * m.Denominator - m.Numerator * n.Denominator, n.Denominator * m.Denominator);
            return new Number((n.Numerator * m.Denominator - m.Numerator * n.Denominator) / red, (n.Denominator * m.Denominator) / red);
        }
        public Number Multiply(Number n, Number m)
        {
            int red = Number.reduce(n.Numerator * m.Numerator, n.Denominator * m.Denominator);
            return new Number((n.Numerator * m.Numerator) / red, (n.Denominator * m.Denominator) / red);
        }
        public Number Devide(Number n, Number m)
        {
            int red = Number.reduce(n.Numerator * m.Denominator, m.Denominator * n.Denominator);
            return new Number((n.Numerator * m.Denominator) / red, (m.Denominator * n.Denominator) / red);
        }
    }
}
