using System;

namespace RownanieKwadratowe
{
    public class Solver
    {
        public static Tuple<double?, double?> Solve(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return new Tuple<double?, double?>(null, null);
            }
            else if (delta == 0)
            {
                return new Tuple<double?, double?>(-b / (2 * a), null);
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return new Tuple<double?, double?>(x1, x2);
            }
        }
    }
}
