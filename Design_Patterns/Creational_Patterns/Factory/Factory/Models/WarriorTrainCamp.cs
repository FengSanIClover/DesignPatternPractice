using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    /// <summary>
    /// 訓練營-鬥士訓練營類別(Concrete Factory)
    /// </summary>
    public class WarriorTrainCamp : ITrainingCamp
    {
        /// <summary>
        /// 訓練冒險者-鬥士
        /// </summary>
        /// <returns></returns>
        public IAdventure TrainAdventure()
        {
            Console.WriteLine("訓練鬥士");
            return new Warrior();
        }
    }
}
