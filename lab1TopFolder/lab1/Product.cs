using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Product
    {
        private string _name;
        private decimal _price;
        private int _quantity;

        public Product()
        {

        }

        public Product(string name, decimal price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public string Name
        {
            get { return _name; }
            set { if (!string.IsNullOrEmpty(value)) _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { if (value > 0) _price = value; }
        }

        public int Quantity => _quantity; //Означає наявність тільке гетера(не гея)

        public decimal TotalValue => _price * _quantity; // same

        public void Restock(int amount)
        {
            if (amount > 0)
            {
                _quantity += amount;
            }
        }

        public void Sell(int amount)
        {
            if (amount < _quantity && amount > 0 ) 
            {
                _quantity -= amount;
            }
        }

        public string GetInfo()
        {
            return $"Name: {_name}, Price: {_price}, Quantity: {_quantity}, Total value: {TotalValue}";
        }

    }
}
