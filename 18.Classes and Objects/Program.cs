using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //create a new book object, at this point Book is now a data type in c#

            //Creation of first book, you can now create thousands of different books e.g for a library app!
            book1.title = "Harry Poter";
            book1.author = "JK Rowling";
            book1.pages = 400;
            book1.price = 250.99;

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;
            book2.price = 250.99;

            Book book3 = new Book();
            book3.title = "The Reign";
            book3.author = "Tolkein";
            book3.pages = 1000;
            book3.price = 200.99;

            Member member1 = new Member();

            member1.name = "Nokwanda";
            member1.address = "5 Simmonds Street";
            member1.phoneNumber = 0797775644;
            member1.age = 24;

            Console.WriteLine(member1.name);
            Console.WriteLine(member1.address);

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);

            //freeze Console
            Console.ReadLine();


        }
    }
}
