using SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Models
{
    /// <summary>
    /// 鬥士類別 (Concrete Product)
    /// </summary>
    public class Warrior : IAdventurer
    {
        /// <summary>
        /// 顯示冒險者類型
        /// </summary>
        public void ShowType()
        {
            Console.WriteLine("我是鬥士");
        }
    }
}
