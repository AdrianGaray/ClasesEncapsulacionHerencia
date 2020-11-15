using System;

namespace ClasesEncapsulacionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("La tempestad","0123456789","Shakespare, Wiliam", "Press");
            ShowPublicationInfo(book);
            book.Publish(new DateTime(2016,8,18));
            ShowPublicationInfo(book);

            Book book2 = new Book("La tempestad","Classic Press", "Shakespare, Wiliam");
            Console.WriteLine($"{book.Title} y {book2.Title} son la misma publicacion?: {((Publication) book).Equals(book2)} ");
            
            Book book3 = new Book("El 10", "JuanPablo Warky", "Futbol");
            book3.SetPrice(15, "USD");
            Console.WriteLine($"El precio del libro {book3.Title} es: { book3.Price}");
            Console.WriteLine($"Autor y Titulo: { book3.ToString()}");
            SetPagesPublicationInfo(book3);      

            Employee employee = new Employee();
            employee.FullName = "Sergio Pérez";
            employee.Age = 40;
            employee.EmployeeId = 123456;
            employee.GetData();
            
            Console.ReadKey();
        }

        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine($"{pub.Title},{(pubDate == "NPA" ? " No se ha publicado aun." : " Publicado el " + pubDate )} by {pub.Publisher}");
        }

        public static void SetPagesPublicationInfo(Publication pub)
        {
            pub.Pages = 10;
            Console.WriteLine($"El libro {pub.Title} tiene: {pub.Pages} paginas.");
        }
    }
}
