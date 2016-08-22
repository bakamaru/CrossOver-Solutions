using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroOne
{
  public  class Program
    {
  
        //public static string Convert(int n)
        //{
        //    return (n > 1 ? Convert(n / 2) : "") + n % 2;
        //}
        //public static List<string> Conversion2(int x)
        //{
        //    var bitConversion = new List<string>();
        //    while (x >= 0)
        //    {
        //        if (x == 0)
        //        {
        //            bitConversion.Add("0");
        //            break;
        //        }
        //        bitConversion.Add((x % 2).ToString(CultureInfo.InvariantCulture));
        //        x /= 2;
        //    }
        //    bitConversion.Reverse();
        //    return bitConversion;
        //}

      public static int Test(int N)
      {

            Int64 S = 0;
            for (int i = 1; i < 100000; i++)
            {
                S = Convert.ToInt64(Convert.ToString(i, 2));
                if (S % N == 0) break;
            }
          return (int) S;

      }
    

      static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                Console.Write("Enter your integer:");
                int N = int.Parse(Console.ReadLine());

                Int64 S = 0;
                for (int i = 1; i < 100000; i++)
                {
                    S = Convert.ToInt64(Convert.ToString(i, 2));
                    if (S%N == 0) break;
                }

                Console.WriteLine(S);

                }
                catch (Exception ex)
                {

                    Console.Write("Please entre integer only!");
                }
            }
            ////Conversion2(4).ForEach(e => { Console.WriteLine(e); });
            ////var ccc = string.Join("", Conversion2(999999));
            ////ccc = ccc.TrimStart(new Char[] { '0' });
            ////Console.WriteLine(ccc);
            ////try
            ////{
            ////    Console.WriteLine(Solution(100));
            ////}
            ////catch (Exception)
            ////{

            ////    throw;
            ////}
            ////long a = 88888;

            ////List<long> list = new List<long>();
            ////list.Add(1);
            ////bool flag = true;

            ////while (flag)
            ////{
            ////    List<long> dummy = new List<long>();
            ////    for (int i = 0; i < list.Count; i++)
            ////    {
            ////        var r = list[i] * 10;
            ////        var r1 = r + 1;
            ////        if (r % a == 0)
            ////        {
            ////            Console.WriteLine(r);
            ////            flag = false;
            ////            break;
            ////        }
            ////        dummy.Add(r);
            ////        dummy.Add(r1);
            ////    }
            ////    list = dummy;
            ////}



        }
    }
}
