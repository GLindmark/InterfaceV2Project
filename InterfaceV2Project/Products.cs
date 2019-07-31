using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    class Products {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Units { get; set; }


        public Products(int id, string Name, decimal Price, int Units) {

            this.Id = id;
            this.Name = Name;
            this.Price = Price;
            this.Units = Units;

        }
    }
}
