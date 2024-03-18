using System.Text;

namespace CounterLib
{
    public class PrintNumbersAndNames
    {
        const long maxUpperBound = 10000000;

        public string PrintAdamKim(int upperBound)
        {
            var sb = new StringBuilder();
            for (int x = 1; x <= upperBound; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    sb.AppendLine("Adam Kim");
                }
                else if (x % 3 == 0)
                {
                    sb.AppendLine("Adam");
                }
                else if (x % 5 == 0)
                {
                    sb.AppendLine("Kim");
                }
                else
                    sb.AppendLine(x.ToString());

            }
            return sb.ToString();
        }

        public string PrintNamesSometimes(int upperBound, (int, int) multiples, (string, string) names)
        {
            if (upperBound > maxUpperBound)
            {
                throw new ArgumentException();
            }
            var (v1, v2) = multiples;

            var (n1, n2) = names;
            var combinedName = n1 + " " + n2;

            var sb = new StringBuilder();
            for (int x = 1; x <= upperBound; x++)
            {
                if (x % v1 == 0 && x % v2 == 0)
                {
                    sb.AppendLine(combinedName);
                }
                else if (x % v1 == 0)
                {
                    sb.AppendLine(n1);
                }
                else if (x % v2 == 0)
                {
                    sb.AppendLine(n2);
                }
                else
                    sb.AppendLine(x.ToString());

            }
            return sb.ToString();
        }
    }
}
