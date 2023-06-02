using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary1
{
    public class Trigonometry
    {
        public static double Sin(string ac, string ab)
        {
            Double.TryParse(ac.ToString(), out double num1);
            Double.TryParse(ab.ToString(), out double num2);
            return num1 / num2;
        }

        public static double Cos(string bc, string ab)
        {
            Double.TryParse(ab.ToString(), out double num1);
            Double.TryParse(ab.ToString(), out double num2);
            return num2 / num1;
        }

        public static double Tan(string bc, string ac)
        {
            Double.TryParse(ac.ToString(), out double num1);
            Double.TryParse(bc.ToString(), out double num2);
            return num1 / num2;
        }

        public static double CTan(string bc, string ac)
        {
            Double.TryParse(ac.ToString(), out double num1);
            Double.TryParse(bc.ToString(), out double num2);
            return num2 / num1;
        }

        public static double ArcSin(string x)
        {
            Double.TryParse(x.ToString(), out double num1);
            num1 = Math.Sin(num1);
            return num1;
        }
        //неуверен что лучше брать
        //public static double ArcSin(double bc, double ab)
        //{
        //    Double.TryParse(c.ToString(), out double num1);
        //    Double.TryParse(ab.ToString(), out double num2);
        //    return num2 / num2;
        //}

    }
}
