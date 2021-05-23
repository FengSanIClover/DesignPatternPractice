using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interface
{
    /// <summary>
    /// 訓練營介面(Factory)
    /// </summary>
    public interface ITrainingCamp
    {
        /// <summary>
        /// 訓練冒險者
        /// </summary>
        /// <returns></returns>
        IAdventure TrainAdventure();
    }
}
