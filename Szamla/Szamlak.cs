using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamla
{
    public class Szamlak
    {
       
            public string InvoiceNumber { get; set; }
            public int Price { get; set; }
            public string CustomerName { get; set; }
            public DateTime PurchaseDate { get; set; }
            public List<string> Items { get; set; }

            public Szamlak(string invoiceNumber,int price, string customerName, DateTime purchaseDate)
            {
                InvoiceNumber = invoiceNumber;
                Price = price;
                CustomerName = customerName;
                PurchaseDate = purchaseDate;

            }
        public void AddItem(string newItem)
        {
            Items.Add(newItem);
        }
        public void TotalAmount()
        { 
            Console.WriteLine("A végösszeg: "+Price+"Ft");




        }

        public override string? ToString()
        {
            return $"{this.InvoiceNumber}, {this.CustomerName}, {this.Price}, {this.PurchaseDate}";
        }
    }
}
