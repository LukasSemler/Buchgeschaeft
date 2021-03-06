﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    public class AudioBook : Book
    {
        internal  int duration;

        public AudioBook(decimal price, int stock, string titel, string author, string isbn, int duration, Category category) : base(price, stock, titel, isbn, author, category)
        {
            this.duration = duration;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Titel} ({this.author}, {duration} minutes ({(int)this.category})) ";
        }
    }
}
