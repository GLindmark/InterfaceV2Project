using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    public class Services {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Hours { get; set; }

        public Services (int id, string Name, decimal rate, int hours) {

            this.Id =  id;
            this.Name = Name;
            this.Rate = rate;
            this.Hours = Hours;
        }

    }
}
