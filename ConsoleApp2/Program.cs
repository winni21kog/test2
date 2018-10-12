using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            //test
            UNEntities db = new UNEntities();
            var q = db.Activity.Where(a => a.StatusID == "AE").ToList();
            Console.WriteLine("test");
            for (int i = 0; i < q.Count; i++)
            {
                Console.WriteLine(q[i].ActName.ToString());
            }
            string bang = "bang";
            Console.WriteLine(bang.ToUpper());
            Console.ReadLine();
            
            

        }
    }
}
