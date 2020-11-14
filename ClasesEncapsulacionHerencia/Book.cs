using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEncapsulacionHerencia
{
    public class Book : Publication
    {
        public string ISBN { get; }
        public string Author { get; }
        public Decimal Price { get; private set; }
        public string Currency { get; private set; } // Tipo de Moneda. Ejemplo; USD

        // Encadenamiento de Constructores
        public Book(string title, string author, string publisher) : this(title, String.Empty, author, publisher) { }
        public Book(string title, string isbn, string author, string publisher) : base(title, publisher, PublicationType.Book)
        {
            if (!String.IsNullOrEmpty(isbn))
            {
                if (!(isbn.Length == 10 ||isbn.Length == 13))
                    throw new ArgumentException("El ISBN debe ser de 10 a 13 caraceres.");

                ulong nISBN = 0;
                if (!UInt64.TryParse(isbn, out nISBN))
                    throw new ArgumentException("EL ISBN consiste de caracteres numerico solamente.");                
            }

            this.ISBN = isbn;
            this.Author = author;
        }

        public Decimal SetPrice(Decimal price, string currency)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException("El precio no puede ser negativo.");

            Decimal oldValue = Price;
            Price = price;

            if (currency.Length != 3)
                throw new ArgumentException("El simbolo de moneda ISO es de 3 carateres.");

            this.Currency = currency;

            return oldValue;
        }

        public override int GetHashCode()
        {
            return ISBN.GetHashCode();
        }

        public override string ToString()
        {
            return $"{(String.IsNullOrEmpty(this.Author) ? "" : Author + ",")}{this.Title}";
        }

        public override bool Equals(object obj)
        {
            Book book = obj as Book;
            if (book == null)
                return false;
            else
                return ISBN == book.ISBN;
        }
    }
}
