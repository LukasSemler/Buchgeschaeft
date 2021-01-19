using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    enum Category
    {
        History = 10,
        Thriller = 20, 
        Fantasy = 30, 
        Food = 40, 
        Chiildren = 50,
    }

     class Book : Item  
    {
        protected string author;
        protected string isbn;
        protected Category category; 

        public Book(decimal price, int stock, string titel, string author, string isbn, Category category):base(price, stock, titel)
        {
            this.author = author; 
            this.isbn = isbn;
            this.category = category;

        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {Titel} ({author} ({(int)this.category}))";
        }
    }
}
