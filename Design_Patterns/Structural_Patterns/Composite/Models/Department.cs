using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Models
{
    /// <summary>
    /// 部門類別-組合類別
    /// </summary>
    public class Department : IAssociation
    {
        private string name;
        private string duty;

        public Department(string name,string duty)
        {
            this.name = name;
            this.duty = duty;
        }

        /// <summary>
        /// 印出組織結構圖
        /// </summary>
        public void Display(int depth)
        {
            for(int i = 0; i < depth; i += 1)
            {
                Console.Write("-");
            }

            Console.WriteLine($"部門名稱:{this.name}");
        }

        /// <summary>
        /// 印出組織職責
        /// </summary>
        public void LineOfDuty()
        {
            Console.WriteLine($"部門職責:{this.duty}");
        }
    }
}
