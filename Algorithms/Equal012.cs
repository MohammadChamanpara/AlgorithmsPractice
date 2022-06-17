using System.Collections.Generic;

namespace Algorithms
{
    public class Equal012
    {
        public static int Run(string str)
        {
            int sum = 0, zero = 0, one = 0, two = 0;
            var counts = new Dictionary<(int, int), int>();
            foreach (var c in str)
            {
                zero += c == '0' ? 1 : 0;
                one += c == '1' ? 1 : 0;
                two += c == '2' ? 1 : 0;

                sum += zero == one && one == two ? 1 : 0;

                var key = (zero - one, one - two);

                if (counts.ContainsKey(key))
                    sum += counts[key]++;
                else
                    counts.Add(key, 1);
            }
            return sum;
        }
    }
}