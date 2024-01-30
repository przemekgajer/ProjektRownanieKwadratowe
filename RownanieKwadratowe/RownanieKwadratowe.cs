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

        }
    }
}
