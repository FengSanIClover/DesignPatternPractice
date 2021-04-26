using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    /// <summary>
    /// 狗類別-繼承動物界面
    /// </summary>
    class Dog : IAnimal
    {
        /// <summary>
        /// 實作吃的方法
        /// </summary>
        public void Eat()
        {
            Console.WriteLine("狗吃東西");
        }

        ///// <summary>
        ///// 實作飛行的方法
        ///// </summary>
        //public void Fly()
        //{
        //    Console.WriteLine("狗沒有翅膀不能飛~為不需要有的方法");
        //}
    }
}
