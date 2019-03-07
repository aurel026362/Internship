using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Nullable
{
    partial class NullableOp
    {
        public NullableOp()
        {
            var books = new List<Book>();
            books.Add(new Book { name = "capra cu trei iezi", code = "123456", page = 234 });
            books.Add(new Book { name = "Povestea lui harap alb", code = "532321", page = 125 });
            books.Add(new Book { name = "C# Spravocinic", code = "5431432", page = 758 });
            books.Add(new Book { name = "C# Generics and Collections", code = "279438", page = 823 });

            Console.WriteLine("Initial list: ");
            ShowData(books);

            Console.WriteLine("\nBooks sorted by page: ");
            books.Sort(new ComparerByPage());
            ShowData(books);
            
           

            Dictionary<Book, string> dBooks = new Dictionary<Book, string>( new BookEqualityComparer());
            dBooks.Add(new Book { name = "Cat and Dog", code = "65ad231", page = 152}, "cat");
            dBooks.Add(new Book { name = "Tom and Jerry", code = "6543sdad", page = 621 }, "mouse");

            Console.WriteLine(dBooks.ContainsKey(new Book { name = "Cat and Dog", code = "65ad231", page = 152 }));
        }

        public void ShowData(List<Book> b)
        {
            Console.WriteLine("List of books: ");
            foreach (Book book in b)
            {
                Console.WriteLine(book.name + " " + book.code + " " + book.page);
            }

            ////Covariance
            //IEnumerable<object> list = new List<string>();

            ////Contravariance
            //Action<object> contr = Get;
        }

        public void Get(object o)
        {

        }
    }
}
