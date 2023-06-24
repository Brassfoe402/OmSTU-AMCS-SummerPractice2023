namespace SquareEquationLib
{
    public class SquareEquation
    {
        public static double[] Solve(double a, double b, double c)
        {
            if (double.IsNaN(a) || double.IsInfinity(a))
            {
                throw new ArgumentException("A coefficient is not a valid number.");
            }

            if (double.IsNaN(b) || double.IsInfinity(b))
            {
                throw new ArgumentException("B coefficient is not a valid number.");
            }

            if (double.IsNaN(c) || double.IsInfinity(c))
            {
                throw new ArgumentException("C coefficient is not a valid number.");
            }

            if (a == 0)
            {
                throw new ArgumentException("A coefficient cannot be zero.");
            }

            double discriminant = b * b - 4 * a * c;
            double[] result;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                result = new double[] { x1, x2 };
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                result = new double[] { x };
            }
            else
            {
                result = new double[0];
            }

            return result;
        }
    }
}
