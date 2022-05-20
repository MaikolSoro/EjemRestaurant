using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
     class Restaurant
    {

        public Mesa[] Mesas { get; set; }

        public Restaurant()
        {
            Mesas = new Mesa[5];
            for (int i = 0; i < 5; i++)
            {
                Mesas[i] = new Mesa { NumMesa = i + 1 };
            }
        }

        internal string ListaMesas()
        {
            string mesas = "Restaurante UTN v0.1\nMesas Disponibles: \n";
            foreach (Mesa mesa in Mesas)
            {
                int total = mesa.Total();
                string algo = total <= 0 ? "" : String.Format(" (${0})", total);
                mesas += String.Format("{0}{1}\n", mesa, algo);
            }
            return mesas + "Seleccione una opción";
        }
    }
}
