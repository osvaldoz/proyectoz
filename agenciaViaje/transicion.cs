
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenciaViaje
{
    class transicion
    {   

        public transicion(bool guia, bool viaje, bool seguros, bool transporte, bool hotel)
        {
            if (viaje == true)
            {
                Viaje v = new Viaje();
                v.ShowDialog();
            }

            if (hotel == true)
            {
                Hotel h = new Hotel();
                h.ShowDialog();
            }

            if (transporte == true)
            {
                Transporte t = new Transporte();
                t.ShowDialog();
            }

            if (guia == true)
            {
                Guia g = new Guia();
                g.ShowDialog();
            }

          
            if (seguros == true)
            {
                Seguros s = new Seguros();
                s.ShowDialog();
            }

        }

    }
}
