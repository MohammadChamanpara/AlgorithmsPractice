using System.Linq;

namespace Algorithms.Tests.Arrays
{
    internal class HotelBooking
    {
        internal static bool Run(int[] arrivals, int[] departures, int availableRooms)
        {
            arrivals = arrivals.OrderBy(x => x).ToArray();
            departures = departures.OrderBy(x => x).ToArray();

            int j = 0, i = 0;
            int clients = 0;
            while (i < arrivals.Length)
            {
                if (arrivals[i] < departures[j])
                {
                    if (++clients > availableRooms)
                        return false;
                    i++;
                }
                else if (arrivals[i] > departures[j])
                {
                    clients--;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }
            return true;
        }
    }
}