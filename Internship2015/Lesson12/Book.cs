using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
  public  class Book
    {
      public string Name;
      public decimal Price;
      public string Category;
      public int Id;

      public override string ToString()
      {
         return(Id+" " +Name+" "+Category);
      }

    }
}
