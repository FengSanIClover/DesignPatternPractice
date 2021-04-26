using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    /// <summary>
    /// 圓形類別-繼承外型介面
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// 比較方法-類別彼此之間都需知道對方，若有新增類別就要修改，違反原則
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if(obj is Square)
            {
                return -1;
            }

            if (obj is Triangle)
            {
                return -1;
            }

            return 0;
        }

        /// <summary>
        /// 畫圖
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("畫圓形");
        }
    }
}
