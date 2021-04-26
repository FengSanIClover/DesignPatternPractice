using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    /// <summary>
    /// 數據機介面-包含二職責，連接管理、資料通訊
    /// </summary>
    public interface IModem
    {
        /// <summary>
        /// 撥號
        /// </summary>
        public void Dial();
        /// <summary>
        /// 掛斷
        /// </summary>
        public void HandUp();

        /// <summary>
        /// 發出
        /// </summary>
        public void Send();
        /// <summary>
        /// 接收
        /// </summary>
        /// <returns></returns>
        public void Recv();
    }
}
