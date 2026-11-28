using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace C__Basics_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
           //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
           //  both title and upperTitle to show that title did not change
           //string title = "clean code";
           //string newTitle = title.ToUpper();
           //Console.WriteLine(title);
           //Console.WriteLine(newTitle);

            #endregion
            #region Q2
           //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
           // to check if they point to the same object in memory
           //string title1 = "Clean Code";
           // string title2 = "Clean Code";
           // Console.WriteLine(ReferenceEquals(title1, title2));

            #endregion
            #region Q3
           //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
           //object.Print the final result.
           //StringBuilder sb = new StringBuilder("Book List");
           // sb.Append(" - Updated");
           //Console.WriteLine(sb);

            #endregion
            #region Q4
           //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
           //  Print the result.

           //sb.Replace("Book List", "Library");
           //Console.WriteLine(sb);
            #endregion
            #region Q5
           //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
           // Pages: 464" using the + operator
           //string title = "Clean Code";
           //int pages = 464;
           //string result = " Book :  " + title + " ,  Pages : " +pages;
           //Console.WriteLine(result);
            #endregion
            #region Q6
           //   Build the same sentence as above, but using string interpolation ($"...").
           //   string title = "Clean Code";
           //int pages = 464;
           //string result = $"Book : {title} , Pages : {pages}";
           //Console.WriteLine(result);
            #endregion
            #region Q7
           //Build the same sentence again, but using string.Format().
           //string title = "Clean Code";
           //int pages = 464;
           //string result = string.Format("Book : {0} , Pages : {1}", title, pages);
           //Console.WriteLine(result);
            #endregion
            #region Q8
           //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
           // 300, otherwise prints "Short Book".
           //int pages = 464;
           //if(pages > 300)
           //{
           //    Console.WriteLine("Long Book");
           //}
           //else
           //{
           //    Console.WriteLine("Short Book");
           //}
            #endregion
            #region Q9
           //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
           //  greater than 300 and isAvailable is true.Use the && operator
           //int pages = 464;
           //bool isAvailable = true;
           //if(pages > 300 && isAvailable) { Console.WriteLine("You can borrow this book"); }

            #endregion
            #region Q10

           // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
           //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else

           //string title = "Refactoring";
           //    switch (title)
           //{
           //    case  "Clean Code":
           //        Console.WriteLine("Great choice!");
           //        break;
           //    case "Refactoring":
           //        Console.WriteLine("Nice pick!");
           //        break;
           //    default:
           //        Console.WriteLine("Never heard of it");
           //        break;


           //}
            #endregion
            #region Q11
           //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
           // variable sizeLabel(same rule as question 8: long if pages > 300).
           //int pages = 464;
           //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
           //Console.WriteLine(sizeLabel);
            #endregion
            #region Q12
           //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
           // to print each book with its position number, like 1.Clean Code
           //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
           //for (int i=0; i< books.Length; i++)
           //{
           //    Console.WriteLine($"{i + 1}. {books[i]}");
           //}
            #endregion

            #region Q13
           // ..Using the same books array, use a while loop to print every book title
           //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" }
           // ;
           // int i = 0;
           // while (i<books.Length)
           // {
           //     Console.WriteLine(books[i]);
           //     i++;
           // }

            #endregion
            #region Q14
           ////Write a do-while loop that prints "Checking book..." exactly 3 times.
           //int i = 0;
           //do
           //{
           //    Console.WriteLine("Checking book...");
           //    i++;
           //} while (i < 3);
            #endregion
            #region Q15
           //Using the same books array, use a foreach loop to print every book title
           //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
           //foreach(string book in books)
           //{
           //    Console.WriteLine(book);
           //}

            #endregion

            #region Q16
           //Using the same books array, loop through it and print each title, but stop completely (break) once
           // you reach "Refactoring".
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" }
            
            //;
            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(book);
            //}
            #endregion

        }
    }
}
