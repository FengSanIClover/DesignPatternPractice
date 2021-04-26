using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            // 介面隔離原則範例
            Console.WriteLine("違反介面隔離原則範例");
            // 柴犬
            Dog shibaInu = new Dog();
            shibaInu.Eat();
            Console.WriteLine("狗應當沒有飛行的方法需要移除");
            // shibaInu.Fly();
            Console.WriteLine("");

            // 麻雀
            Bird sparrow = new Bird();
            sparrow.Eat();
            sparrow.Fly();
            Console.WriteLine("");

            Console.WriteLine("符合介面隔離原則範例-飛行的方法介面與動物界面隔離開來");

            // 拉不拉多
            Dog labradorRetriever = new Dog();
            labradorRetriever.Eat();
            Console.WriteLine("");

            // 蜂鳥
            Bird hummingbird = new Bird();
            hummingbird.Eat();
            hummingbird.Fly();
        }
    }
}
