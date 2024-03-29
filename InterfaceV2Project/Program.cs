﻿using System;

namespace InterfaceV2Project {

    class Program {

        static void Main(string[] args) {

            var p1 = new Products(1, "Basic Widget", 10, 2500);
            var p2 = new Products(2, "Advanced Widget", 25, 1500);
            var p3 = new Products(3, "Supreme Widget", 50, 1000);

            var s1 = new Services(4, "Basic Service", 25, 1000);
            var s2 = new Services(5, "Priority Service", 50, 550);
            var s3 = new Services(6, "24x7 Service", 100, 750);

            var m1 = new Membership(7, "Basic", 100, 1500);
            var m2 = new Membership(8, "Advanced", 200, 700);
            var m3 = new Membership(9, "Premier", 400, 300);

            //var products = new Products[] { p1, p2, p3 };//one of the only times you will put a semicolon after a curlybrace.  it is to initiate an array
            // var services = new Services[] { s1, s2, s3 };


            var pands = new ICalcSales[] { p1, p2, p3, s1, s2, s3, m1, m2, m3};

            decimal total = 0M;

            foreach(var pors in pands) {
                total += pors.CalcSales();
            }

                //foreach(var prod in products) {
                //total += prod.CalcSales();

                //foreach(var serv in services) {
                //    total += serv.CalcSales();
                //}

                //foreach (var serv in Membership) {
                //    total += serv.CalcSales();
                //}

                Console.WriteLine($"Total Sales is {total}");
            

        }
    }
}
