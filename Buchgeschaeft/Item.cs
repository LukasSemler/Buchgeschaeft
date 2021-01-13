﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
     class Item
    {
        decimal price;
        int stock;
        public string Titel { get; }

        public Item(decimal price, int stock, string titel)
        {
            Titel = titel;
            this.price = price;
            this.stock = stock;
        }


        public bool TryPurchase(int number)
        {
            stock += number;
            return true;
        }


        public bool TrySell(int number)
        {
            if (number > stock)
            {
                return false;
            }
            else if (number <= stock)
            {
                stock -= number;
                return true;
            }
            else
                return false; 
        }
    }
}