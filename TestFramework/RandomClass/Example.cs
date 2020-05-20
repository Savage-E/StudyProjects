namespace RandomClass
{
    public class Example
    {
        public double Multiplicaton(double a, double b)
        {
            if (a == 0 || b == 0)
                return 0;

            return a * b;
        }

        public string Concatenation(string str1, string str2)
        {
            return str1 + str2;
        }

        public int MaxElement(int[,] mtrx)
        {
            int max = 0;

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(0); j++)
                {
                    if (max < mtrx[i, j])
                        max = mtrx[i, j];
                }
            }
            return max;
        }

        public bool IsPositiveNumber(int n)
        {
            if (n >= 0)
                return true;
            else
                return false;
        }
    }
}