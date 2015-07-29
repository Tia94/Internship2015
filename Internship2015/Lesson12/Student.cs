using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
 public  class Student
    {
     public string Name { get; set; }
     public int age { get; set; }
     public int SchoolYear;
     
     public override string ToString()
     {
         return (Name + " " +age);
     }

    }
}
