namespace course
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ValorTotal(double c, double q)
        {
            double total = c * q;
            return total + total * Iof;
        }
    }
}
