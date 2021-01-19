using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschaeft
{
    class Newspaper : Item
    {
        protected DateTime dateOfIssue;

        public Newspaper(decimal price, int stock, string title, DateTime dateOfIssue) : base(price, stock, title)
        {
            this.dateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Titel} ({dateOfIssue}) ";
        }
    }
}
