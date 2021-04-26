using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    /// <summary>
    /// 矩形類別
    /// </summary>
    public class Rectangle
    {
        public virtual double Width { get; set; }

        public virtual double Height{ get; set; }

        /// <summary>
        /// 計算面積
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return this.Width * this.Height;
        }
    }
}
