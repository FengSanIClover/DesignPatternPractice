using SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Models
{
    /// <summary>
    /// 弓箭手類別 (Concrete Product)
    /// </summary>
    public class Archer : IAdventurer
    {
        /// <summary>
        /// 顯示冒險者類型
        /// </summary>

        public void ShowType()
        {
            Console.WriteLine("我是弓箭手");
        }
    }
}
