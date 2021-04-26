using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    /// <summary>
    /// 數據機-資料通訊
    /// </summary>
    public interface IDataChannel
    {
        /// <summary>
        /// 撥號
        /// </summary>
        public void Dial();
        /// <summary>
        /// 掛斷
        /// </summary>
        public void HandUp();
    }
}
