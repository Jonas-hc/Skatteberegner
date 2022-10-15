using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            double beskattetBelob = 0;
            double gaverIalt = andenGave;

            if (julegave < 900)
            {
                gaverIalt += julegave;
            }

            if (gaverIalt > 1200)
            {
                beskattetBelob = gaverIalt - 1200;
            }

            return beskattetBelob;
        }
    }
}
