using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGrafico
{
    internal static class RisolutoreHanoi
    {
        public static int Hanoi(int numDischi, char DA, char A, char ALTRO, List<(char Da, char A)> cronologia)
        {
            if (numDischi < 1)
                throw new Exception();

            if (numDischi == 1)
            {
                cronologia.Add((DA, A));
                return 1;
            }
            else
            {
                int numMinimoMosse = 0;
                numMinimoMosse += Hanoi(numDischi - 1, DA, ALTRO, A, cronologia);
                numMinimoMosse += Hanoi(1, DA, A, ALTRO, cronologia);
                numMinimoMosse += Hanoi(numDischi - 1, ALTRO, A, DA, cronologia);
                return numMinimoMosse;
            }
        }
    }
}
