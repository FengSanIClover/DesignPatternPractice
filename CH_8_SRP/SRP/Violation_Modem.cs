using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    /// <summary>
    /// 違反單一職責原則的 Modem 類別，
    /// 多個職責由單一類別而來
    /// </summary>
    public class Violation_Modem : IModem
    {
        /// <summary>
        /// 撥號
        /// </summary>
        public void Dial()
        {
            Console.WriteLine("執行撥號");
        }

        /// <summary>
        /// 掛斷
        /// </summary>
        public void HandUp()
        {
            Console.WriteLine("執行掛斷");
        }

        /// <summary>
        /// 接收
        /// </summary>
        /// <returns></returns>
        public void Recv()
        {
            Console.WriteLine("執行接收");
        }

        /// <summary>
        /// 發出
        /// </summary>
        public void Send()
        {
            Console.WriteLine("執行發出");
        }
    }
}
