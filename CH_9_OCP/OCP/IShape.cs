using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    /// <summary>
    /// 外型介面
    /// </summary>
    public interface IShape : IComparable
    {
        /// <summary>
        /// 畫圖
        /// </summary>
        public void Draw();
    }
}
