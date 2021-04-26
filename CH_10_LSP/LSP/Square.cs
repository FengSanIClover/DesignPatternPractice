using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    /// <summary>
    /// 方形類別-繼承矩形
    /// </summary>
    public class Square:Rectangle
    {
        public override double Width 
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}
