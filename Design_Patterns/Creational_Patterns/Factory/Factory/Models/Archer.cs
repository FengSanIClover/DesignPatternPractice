using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    /// <summary>
    /// 冒險者-弓箭手類別(Concrete Product)
    /// </summary>
    public class Archer : IAdventure
    {
        /// <summary>
        /// 顯示冒險者種類
        /// </summary>
        public void ShowType()
        {
            Console.WriteLine("我是弓箭手");
        }
    }
}
