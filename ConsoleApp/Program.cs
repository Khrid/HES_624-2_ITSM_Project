﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPaymentServiceReference.PrintPaymentServiceClient client = new PrintPaymentServiceReference.PrintPaymentServiceClient();


            // Happy path
            Console.WriteLine("--- TEST HAPPY PATH ---");
            // -> Point of sale
            Console.WriteLine("Point of sale -> transaction id " + client.TransactionPointOfSale(7789, 10));
            // -> Pay online
            Console.WriteLine("Pay online -> transaction id " + client.TransactionPayOnline("sylvain.meyer", 11));
            // -> Faculties
            Console.WriteLine("Faculties -> transaction id " + client.TransactionFaculties("david.crittin", 12));
            // -> Print system
            Console.WriteLine("Print system -> transaction id " + client.TransactionAddQuotasPrintSystem("alain.duc", 10));

            // id inexistants
            Console.WriteLine("\n--- TEST ID INEXISTANTS ---");
            // -> Point of sale
            Console.WriteLine("Point of sale -> transaction id " + client.TransactionPointOfSale(1478, 10));
            // -> Pay online
            Console.WriteLine("Pay online -> transaction id " + client.TransactionPayOnline("michel.vincent", 11));
            // -> Faculties
            Console.WriteLine("Faculties -> transaction id " + client.TransactionFaculties("nicolas.debons", 12));
            // -> Print system
            Console.WriteLine("Print system -> transaction id " + client.TransactionAddQuotasPrintSystem("anne.lecalve", 10));

            Console.ReadLine();

        }

    }
}
