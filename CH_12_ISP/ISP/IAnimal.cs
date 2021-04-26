using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    /// <summary>
    /// 動物界面
    /// </summary>
    interface IAnimal
    {
        /// <summary>
        /// 動物-吃方法
        /// </summary>
        void Eat();

        // 因為飛行並非所有動物都有的行為，因此需用其他介面來設計
        ///// <summary>
        ///// 動物-飛行方法
        ///// </summary>
        //void Fly();
    }
}
