using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liskov 里式替換原則範例
            Console.WriteLine("Liskov 里式替換原則範例");
            Console.WriteLine("=====================違反案例========================");
            Square s = new Square();
            s.Width = 1;
            s.Height = 2;

            // Console.WriteLine("Width : {0}", s.Width);
            //test(s);
            Rectangle r = new Rectangle();
            //r.Width = 10;
            //r.Height = 12;
            //Console.WriteLine("Height : {0}", r.Height);
            //test(r);
            Calc(r);
            Calc(s);
            Console.WriteLine("=================================================");
            Follow_Square fs = new Follow_Square();
            Follow_Rectangle fa = new Follow_Rectangle();
            Follow_Calc(fs);
            Follow_Calc(fa);
        }

        static void test(Rectangle r)
        {
            r.Width = 32;
            Console.WriteLine("Width : {0}", r.Height);
        }

        /// <summary>
        /// 透過類別計算方法，
        /// 方形類別會出錯
        /// 矩形類別可以過
        /// 子類別無法替換父類別違反 LSP
        /// </summary>
        /// <param name="r"></param>
        static void Calc(Rectangle r)
        {
            r.Width = 5;
            r.Height = 4;
            if(r.Area() != 20)
            {
                Console.WriteLine("計算失敗");
                // throw new Exception("計算錯誤");
            }
        }

        /// <summary>
        /// 透過類別計算方法，
        /// </summary>
        /// <param name="r"></param>
        static void Follow_Calc(ShapeAbstract r)
        {
            r.Width = 5;
            r.Height = 4;
            Console.WriteLine("面積:{0}", r.Area());
        }
    }
}
