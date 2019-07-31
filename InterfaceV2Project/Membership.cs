using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    class Membership : ICalcSales {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public decimal Units { get; set; }

        public Membership(int id, string Name, decimal Fee, decimal Units) {

            this.Id = id;
            this.Name = Name;
            this.Fee = Fee;
            this.Units = Units;
        }



            public decimal CalcSales() {
            return Fee * Units;
        }
        public string About() {
            return "About Memberships";
        }
    }
}
