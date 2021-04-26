using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    /// <summary>
    /// 矩形抽象類別-定義
    /// </summary>
    public abstract class ShapeAbstract
    {
        /// <summary>
        /// 寬
        /// </summary>
        public virtual int Width { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        public virtual int Height { get; set; }

        /// <summary>
        /// 計算面積
        /// </summary>
        /// <returns></returns>
        public virtual int Area() 
        {
            return this.Width * this.Height;
        }
    }
}
