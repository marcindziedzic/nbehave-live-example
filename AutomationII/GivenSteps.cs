using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBehave.Narrator.Framework;

namespace AutomationII
{
    [ActionSteps]
    public class GivenSteps
    {
        [Given("I am not logged in")]
        public void EnsureNotLoggedIn()
        {
            string driver = (string) FeatureContext.Current["webdriver"];

            Console.WriteLine("retrieved webdriver -> " + driver);
            Console.WriteLine("EnsureNotLoggedIn");
        }

        [Given("simple array $values")]
        public void ArraySpecification(int[] values)
        {
            Console.WriteLine("Array has been passed");
            foreach (int item in values)
                Console.WriteLine("value -> " + item);
        }

        [Given("I have entered $number into the calculator")]
        public void OutlineSpecification(int number) 
        {
            Console.WriteLine("entered number -> " + number);
        }

        [Given("a list of books:")]
        public void givenListOfBooks(List<Book> books)
        {
            Console.WriteLine("List of books");
            foreach (Book book in books)
            {
                Console.WriteLine("Book.title: " + book.Title);
                Console.WriteLine("Book.ISBN: " +  book.ISBN);
            }
        }
    }

    public class Book
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _isbn;

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

    }
}
