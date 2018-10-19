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
        #region ex1:get
        ////建立 A 類別
        //public class A
        //{
        //    //包含兩個string 
        //    public string name;
        //    public string st
        //    {
        //        //使用get存取子
        //        get
        //        {
        //            if (name != null)
        //            {
        //                return name;
        //            }
        //            else
        //            {
        //                return "default";
        //            }
        //        }

        //    }
        //}


        //static void Main(string[] args)
        //{
        //    //實例化A類別
        //    A x = new A();
        //    //設定A.name
        //    //x.name = "Brown";
        //    //取得 st
        //    Console.WriteLine("帳號:" + x.st);
        //    Console.ReadLine();
        //}
        #endregion

        #region ex2:set
        ////建立 A 類別
        //public class A
        //{
        //    //包含兩個string
        //    public string v;
        //    public string st
        //    {
        //        //使用set存取子
        //        set
        //        {
        //            //不多解釋，傳入值都會存在 value
        //            Console.WriteLine("帳號:" + value);
        //        }

        //    }
        //}
        //static void Main(string[] args)
        //{
        //    //實例化A類別
        //    A x = new A();
        //    //A.st 傳入值
        //    x.st = "Adam";
        //    Console.ReadLine();

        //}
        #endregion

        #region ex3:get and set
        //建立 A 類別
        public class A
        {
            public string v;
            public string name;
            //A class被實例化時，會立即執行建構子內容，並且可以傳入參數
            public string Show
            {
                get { return name; }
                set
                {
                    name = v;
                    Console.WriteLine("I am " + value);
                }
            }
            
        }

        static void Main(string[] args)
        {
            //實例化A類別
            A x = new A();

            x.v = "Brown";
            x.Show = "Joe";
            Console.WriteLine(x.Show);
            Console.ReadLine();
        }
        #endregion

        #region main
        //static void Main(string[] args)
        //{
        //    //test
        //    UNEntities db = new UNEntities();
        //    var q = db.Activity.Where(a => a.StatusID == "AE").ToList();
        //    Console.WriteLine("test");
        //    for (int i = 0; i < q.Count; i++)
        //    {
        //        Console.WriteLine(q[i].ActName.ToString());
        //    }
        //    string bang = "bang";
        //    Console.WriteLine(bang.ToUpper());
        //    Console.ReadLine();
        //}
        #endregion

    }
}
