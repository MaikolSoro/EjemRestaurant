using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
     class Mesa
    {
        public int NumMesa { get; set; }
        public Producto[] Productos { get; set; }

        public int[] Cantidad { get; set; }

        public Mesa()
        {
            Productos = new Producto[]
            {
                new Producto{ Name = "Hamburguesa Sencilla", Price = 15 },
                new Producto{ Name = "Hamburguesa con Queso", Price = 18 },
                new Producto{ Name = "Hamburguesa Especial", Price = 20 },
                new Producto{ Name = "Papas Fritas", Price = 8 },
                new Producto{ Name = "Refresco", Price = 5 },
                new Producto{ Name = "Postre", Price = 6 }

            };
        }
        internal string Menu(bool total)
        {
            string menu = "Restaurante UTN - v0.1\nOrden Actual: \n";
            int cont = 1;
            int t = 0;
            foreach (Producto pro in Productos)
            {
                menu += "  " + cont++ + ". " + pro + "\n";
                if (total)
                {
                    t += pro.Quantity * pro.Price;
                }
            }
            return menu + (!total
                ? "Seleccione una opción o -1 para regresar"
                : (String.Format("TOTAL.................: ${0}"+ "\nPreciona ENTER para continuar ....", t))).PadLeft(40, ' ');
        }

        public int Total()
        {
            int t = 0;
            foreach (Producto pro in Productos)
            {
                t += pro.Quantity * pro.Price;
            }
            return t;

        }

        public override string ToString()
        {
            return String.Format("{0}. Mesa #{0}", NumMesa);
        }

    }
}
