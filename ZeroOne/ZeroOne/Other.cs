using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroOne
{
    public class Other
    {
    }
    public class QWER<T>
    {
        protected T x;
    }

    public class MyQWER<T> : QWER<T>
    {
        private static void F()
        {
            MyQWER<T> dt = new MyQWER<T>();
            MyQWER<int> x = new MyQWER<int>();
            MyQWER<string> y = new MyQWER<string>();
            dt.x = default(T);
            x.x = 76;
            y.x = "fun";
        }
    }


    public class asdf
    {
        protected int x;

        private static void funny(asdf a, asdf b)
        {
            a.x = 1;
            b.x = 1;
        }
    }

    public class childcl : asdf
    {
        private static void funny(asdf a, asdf b)
        {
            //a.x = 1;
            //b.x = 1;
        }
    }

    public interface IFun
    {
        void fun();
        void fun(int x);
        void fun(ref int x);
        // int fun(int x);
    }

    public class test
    {
        private int x;
        private static int y;

        private void fun()
        {
            x = 1;
            y = 2;
            tt("1.0");
        }

        private static void funs()
        {
            y = 1;

        }
        private void tt(double x)
        {
        }
        private void tt(object x)
        {
        }
    }
}
