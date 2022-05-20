using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Program
    {
        static int LeerInt(string msj)
        {
            int num = 0;

        REP:
            Console.Write(msj + ": ");
            string dato = Console.ReadLine();

            if(!Int32.TryParse(dato, out num))
            {
                goto REP;
            }

            return num;
        }
        static void Main(string[] args)
        {
            string menu = "Restaurante UTN - v0.1\n" +
               "1. Capturar Orden\n" +
               "2. Calcular Cuenta\n" +
               "3. Salir\n" +
               "Seleccione una opción ";

            Restaurant rest = new Restaurant();
            while (true)
            {
                int op = LeerInt(menu);
                Console.Clear();
                if (op == 1 || op == 2)
                {
                    int nm = LeerInt(rest.ListaMesas());
                    Mesa m = rest.Mesas[nm - 1];
                    switch (op)
                    {
                        case 1:
                            while (true)
                            {
                                Console.Clear();
                                int np = LeerInt(m.Menu(false));
                                if (np == -1)
                                {
                                    break;
                                }
                                Producto p = m.Productos[np - 1];
                                int can = LeerInt(String.Format("Cantidad de {0}: ", p.Name));
                                p.Quantity += can;
                            }
                            break;
                        case 2:
                            Console.WriteLine(m.Menu(true));
                            rest.Mesas[nm - 1] = new Mesa { NumMesa = nm };
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else if (op == 3)
                {
                    goto APP;
                }
            }
        APP:
            Console.WriteLine("Gracias por utilizar nuestra aplicación");
            Console.ReadKey();


        }
    }
}
