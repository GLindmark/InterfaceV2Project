using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    public class Products : ICalcSales {// the : ICalcSales is the interface.  Therefore the method must be used.  Use suggested from r-squig

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

        public decimal CalcSales() {
            return Price * Units;
        }

        public string About() {
            return "About Products";
        }
    }
}
