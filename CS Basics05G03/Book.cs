using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Basics05G03
{
    internal class Book
    {
        private string password = " secret";

        internal int copiesInStock = 5;

        public string title { get; set; }
        public Genre genre { get; set; } = new Genre();
    }
}
