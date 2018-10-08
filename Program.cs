using System;
using System.Collections.Generic;
using Library;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few (4 or so) instances of books and use the method on your Library class to add them to the list of books in an instance of Library

            // Creating a list of book to pass into the library constructor
            Book book1 = new Book(){
                Title = "a",
                Author = "a",
                ISBN = "a",
            };
            Book book2 = new Book(){
                Title = "b",
                Author = "b",
                ISBN = "b",
            };
            List<Book> books = new List<Book>(){
                book1, book2
            };

            // Create a new library with a premade list of books for it's contructor
            Library NewLibrary = new Library(books, "Downtown Library", "123 Some St. Nashville, TN 12345");
            // before contructor
            // Library NewLibrary = new Library(){
            //     Name = "Downtown Library",
            //     Address = "Someplace Downtown"
            // };

            // creating books
            Book endersGame = new Book() {
                Title = "Ender's Game",
                Author = "Orsen Scott",
                ISBN = "ABC123"
            };
            Book lotr = new Book() {
                Title = "Lord of the Rings",
                Author = "J R R Tolkein",
                ISBN = "ABC125"
            };
            // Alternate way to make a book object
            Book tomSawyer = new Book();
                tomSawyer.Title = "Ender's Game";
                tomSawyer.Author = "Orsen Scott";
                tomSawyer.ISBN = "ABC124";
            // or this way, but you don't get to hold the books in a variable name.
            // NewLibrary.AddToInventory(new Book() {Title = "Something", Author = "Some Dude", ISBN = "A0adf934"});
            // NewLibrary.AddToInventory(new Book() {Title = "Something Else", Author = "Some Other Dude ", ISBN = "sadgfsdgf34"});
            // NewLibrary.AddToInventory(new Book() {Title = "Something More", Author = "AnotherDude", ISBN = "sadfasdgf5676756"});
            // NewLibrary.AddToInventory(new Book() {Title = "Bob", Author = "Bob", ISBN = "B0B"});
        }
    }
}
