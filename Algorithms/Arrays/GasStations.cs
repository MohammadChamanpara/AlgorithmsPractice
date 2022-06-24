namespace Algorithms.Arrays
{
    public static class GasStations
    {
        /*
         * Gas  1 2
         * Cost 2 1
         * 
         */
        public static int Run(int[] gases, int[] costs)
        {
            int stations = gases.Length;
            for (int start = 0; start < stations; start++)
            {
                int gas = 0;
                for (int i = 0; i < stations; i++)
                {
                    int station = (start + i) % stations;
                    gas += gases[station] - costs[station];
                    if (gas < 0)
                        break;
                }
                if (gas >= 0)
                    return start;
            }
            return -1;
        }
    }
}