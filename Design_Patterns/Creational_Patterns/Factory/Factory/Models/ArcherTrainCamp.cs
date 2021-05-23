using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    /// <summary>
    /// 訓練營-弓箭手訓練營類別(Concrete Factory)
    /// </summary>
    public class ArcherTrainCamp : ITrainingCamp
    {
        /// <summary>
        /// 訓練冒險者-弓箭手
        /// </summary>
        /// <returns></returns>
        public IAdventure TrainAdventure()
        {
            Console.WriteLine("訓練弓箭手");
            return new Archer();
        }
    }
}
