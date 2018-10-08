using System;
using System.Collections.Generic;

namespace Library
{
    public class Library
    {
        // Constructor
        public Library(List<Book> initialInventory, string name, string address)
        {
            _bookList = initialInventory;
            Name = name;
            Address = address;
        }
        // Properties
        public string Address { get; set; }
        public string Name { get; set; }
        private List<Book> _bookList = new List<Book>();
        // or
        // private List<Book> _bookList;

        // Methods
        // Methods has to pass the TYPE of object and the variable name
        public void AddToInventory (Book book)
        {
            _bookList.Add(book);
            // or use 'this' to look within this specific class
            // this._bookList.Add(book);
        }
        public void CheckOut (string isbn, CardHolder cardHolder)
        {
            foreach (Book book in _bookList)
            {
                if (book.ISBN == isbn && book.IsAvailable)
                {
                    cardHolder.CheckoutBook(book);
                    book.IsAvailable = false;
                }
            }
            
        }
        public bool IsAvailable(string isbn)
        {
            foreach (Book book in _bookList)
            {
                if (book.ISBN == isbn)
                {
                    return book.IsAvailable;
                }
            }
            return false;
        }
    }
}