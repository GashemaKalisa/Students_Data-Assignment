using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Student_DatabaseEntities();
            var post = new Students_Table
            {
                Students_Id=001,
                FirstName = "Gashema",
                LastName ="Kalisa",
                Grade="A"
            };
            context.Students_Table.Add(post);
            context.SaveChanges();
        }
    }
}
