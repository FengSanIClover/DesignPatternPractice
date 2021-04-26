using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    /// <summary>
    /// 數據機-連接管理
    /// </summary>
    public interface IConnection
    {
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
