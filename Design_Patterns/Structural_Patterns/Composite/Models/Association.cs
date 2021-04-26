using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Models
{
    /// <summary>
    /// 協會類別-組合類別
    /// </summary>
    public class Association : IAssociation
    {
        private string name;
        private string duty;
        // 其餘分支部門、協會
        public List<IAssociation> departments = new List<IAssociation>();

        public Association(string name, string duty)
        {
            this.name = name;
            this.duty = duty;
        }

        /// <summary>
        /// 印出組織結構圖
        /// </summary>
        public void Display(int depth)
        {
            for (int i = 0; i < depth; i += 1)
            {
                Console.Write("-");
            }

            Console.WriteLine($"協會名稱:{this.name}");
            foreach(var department in departments)
            {
                department.Display(depth + 2);
            }
        }

        /// <summary>
        /// 印出組織職責
        /// </summary>
        public void LineOfDuty()
        {
            Console.WriteLine($"組織職責:{this.duty}");
            foreach (var department in departments)
            {
                department.LineOfDuty();
            }
        }
    }
}
