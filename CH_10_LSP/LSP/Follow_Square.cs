using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    /// <summary>
    /// 繼承矩形類別抽象
    /// </summary>
    public class Follow_Square : ShapeAbstract
    {
        /// <summary>
        /// 重新定義 寬度的設定
        /// </summary>
        public override int Width 
        {
            get => base.Width; 
            set 
            {
                base.Width = value;
                base.Height = value;
            } 
        }

        /// <summary>
        /// 重新定義 高度的設定
        /// </summary>
        public override int Height
        {
            get => base.Height;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}
