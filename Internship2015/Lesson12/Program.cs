using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new List<Book>
            {
               new Book
               {
                   Name=" math",
                   Price =300,
                   Id=1,
                   Category="Since"
               },

            new Book
            {
                 Name="C#",
                   Price =400,
                   Id=2,
                   Category="programing"
            },
            
          new Book
            {
                 Name="C++",
                   Price =350,
                   Id=3,
                   Category="programing"
            },

           new Book
            {
                 Name="English",
                   Price =350,
                   Id=3,
                   Category="Since"
            }

           };
            Console.WriteLine("((filtring))");
            var a = library.Take(3);  //filtring
            Console.WriteLine(" The first three books are :");
            foreach (var book in a)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("=======================");


            var books = library.Select(x => x.Name);  //projection
            Console.WriteLine("((projection))");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("=======================");



            Console.WriteLine("((Element operation))");//Element operators
            Console.Write(" The Last book is :");
            var b = library.Last();
            Console.WriteLine(b);
            Console.WriteLine("=======================");



            Console.WriteLine("((Aggregation Method))"); //aggregation method
            Console.Write("The average of the pices is :");
            var b2 = library.Average(x => x.Price);

            Console.WriteLine(b2);

            Console.WriteLine("=======================");






            var student = new List<Student>()
            {
                new Student
                {
                    Name ="Rami",
                    Age=26,
                    SchoolYear = 3


                },

                new Student
                {
                    Name ="Maria",
                    Age=15,
                    SchoolYear=1
                },

                new Student
                {
                    Name ="Patricia",
                    Age=21,
                    SchoolYear=3
                },

                new Student
                {
                    Name ="Shaza",
                    Age=13,
                    SchoolYear=2
                },


            };

            var emptyStudnt = Enumerable.Empty<Student>();  //geneatin method
            var r = Enumerable.Repeat(1, 20);
            var rangeExample = Enumerable.Range(3, 15);


            //var orderStudent = student.OrderBy(x => x.SchoolYear).ThenByDescending(x => x.age);  //ordering

            //var grouping = from students in student    //joining
            //               group students by students.SchoolYear
            //                   into orderByYear
            //                   select new { orderByYear.Key, SchoolYear = orderByYear };




            // foreach (var studentgroup in grouping)
            //        {
            //            Console.WriteLine("Groups that start with a vowel: {0}", studentgroup.Key);
            //            foreach (var word in studentgroup)
            //            {
            //                Console.WriteLine("   {0}", student.Name);
            //            }
            //        }

            //        // Keep the console window open in debug mode
            //        Console.WriteLine("Press any key to exit.");
            //        Console.ReadKey();
            //    }
            //}


            //foreach (IGrouping<char, Student> studentGroup in grouping)
            //{
            //    Console.WriteLine(studentGroup.Key);
            //    // Explicit type for student could also be used here. 
            //    foreach (var s in studentGroup)
            //    {
            //        Console.WriteLine("   {0}, {1}", s.Name, s.age);
            //    }
            //}


            //foreach (var s in orderStudent)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("=======================");



            Console.ReadLine();
        }
    }
}
