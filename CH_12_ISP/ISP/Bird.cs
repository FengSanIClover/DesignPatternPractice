using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    /// <summary>
    /// 鳥類別
    /// </summary>
    class Bird : IAnimal,IFly
    {
        /// <summary>
        /// 實作吃的方法
        /// </summary>
        public void Eat()
        {
            Console.WriteLine("鳥吃東西");
        }

        /// <summary>
        /// 實作飛行的方法
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("鳥飛起來了");
        }
    }
}
