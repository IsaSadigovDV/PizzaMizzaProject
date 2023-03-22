using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Core.Models.Base
{
    public class Pizza
    {
        private static int _count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize size { get; set; }
        public string Ingredients { get; set; }

        private double _price;
        public double price { get => _price;

                set
            {
                _price = value;
            }
             
        }

       
        public Pizza()
        {
            _count++;
            Id = _count;
        }

        public override string ToString()
        {
            return $"Pizza Id: {Id}  Pizza name: {Name} Pizza price: {price} Pizza size: {size}";
        }
    }
}
