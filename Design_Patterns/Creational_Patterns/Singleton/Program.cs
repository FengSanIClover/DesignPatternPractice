using Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("單例模式");

            // 網站計數器
            WebBrowserCounter counter1 = new WebBrowserCounter();
            WebBrowserCounter counter2 = new WebBrowserCounter();

            // 模擬瀏覽人數增加
            for (int i = 0; i < 10; i += 1)
            {
                counter1.Count += 1;
                counter2.Count += 1;
            }

            Console.WriteLine($"網站瀏覽次數1:{counter1.Count}");
            Console.WriteLine($"網站瀏覽次數2:{counter2.Count}");
            Console.WriteLine($"網站期待瀏覽次數為:{counter1.Count + counter2.Count}");
            Console.WriteLine();
            Console.WriteLine("套用單例模式");

            // 透過方法取得執行個體

            // 網站計數器
            WebBrowserCounter_Singleton singletonCounter1 = WebBrowserCounter_Singleton.GetInstance();
            WebBrowserCounter_Singleton singletonCounter2 = WebBrowserCounter_Singleton.GetInstance();

            Thread t = new Thread(() => singletonCounter1.Count +=1);
            t.Start();

            // 模擬瀏覽人數增加
            for (int i = 0; i < 10; i += 1)
            {
                singletonCounter1.Count += 1;
                singletonCounter2.Count += 1;
            }

            Console.WriteLine($"網站瀏覽次數1:{singletonCounter1.Count}");
            Console.WriteLine($"網站瀏覽次數2:{singletonCounter2.Count}");

            Console.ReadLine();
        }
    }
}
