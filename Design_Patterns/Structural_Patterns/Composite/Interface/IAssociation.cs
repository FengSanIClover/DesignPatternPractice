using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Interface
{
    /// <summary>
    /// 協會組件介面
    /// </summary>
    public interface IAssociation
    {
        /// <summary>
        /// 印出組織結構圖
        /// </summary>
        void Display(int depth);

        /// <summary>
        /// 印出組織職責
        /// </summary>
        void LineOfDuty();
    }
}
