using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary1
{
    public class GeometryClass1
    {

        public static double STriangle(string a, string h)
        {
            Double.TryParse(a.ToString(), out double num1);
            Double.TryParse(h.ToString(), out double num2);

            return (num1 * num2) / 2;
        }

        public static double STriangle2(string a, string b)
        {
            Double.TryParse(a.ToString(), out double num1);
            Double.TryParse(b.ToString(), out double num2);
            return (num1 * num2) / 2;
        }

        public static double SRectangle(string a, string b)
        {
            Double.TryParse(a.ToString(), out double num1);
            Double.TryParse(b.ToString(), out double num2);
            return num1 * num2;
        }

        public static double SCircle(string r)
        {
            Double.TryParse(r.ToString(), out double num1);
            return (num1 * num1) * 3.14;
        }

        public static double STrapezoid(string a, string b, string h)
        {
            Double.TryParse(a.ToString(), out double num1);
            Double.TryParse(b.ToString(), out double num2);
            Double.TryParse(h.ToString(), out double num3);

            return ((num1 + num2) * num3) / 2;
        }        
    }
    
}
