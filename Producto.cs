using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
     class Producto
    {
        public String Name { get; set; }
        public int Price { get; set; }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value < 0 ? 0 : value; }
        }

        public override string ToString()
        {
            string can = Quantity == 0 ? "" : String.Format(" => {0}", Quantity.ToString().PadLeft(2, ' '));
            return String.Format("{0}(${1}){2}", Name.PadRight(25, '.'), Price.ToString().PadLeft(3, ' '), can);
        }
    }
}
