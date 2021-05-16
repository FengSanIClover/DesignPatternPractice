using SimpleFactory.Enums;
using SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Models
{
    /// <summary>
    /// 冒險者訓練營 (Simple Factory)
    /// </summary>
    public class TrainingCamp
    {
        /// <summary>
        /// 訓練冒險者
        /// </summary>
        /// <param name="type"></param>
        public static IAdventurer TrainAdventurer(AdventurerType type)
        {
            switch (type)
            {
                case AdventurerType.Archer:
                    Console.WriteLine("訓練一個弓箭手");

                    return new Archer();
                case AdventurerType.Warrior:
                    Console.WriteLine("訓練一個鬥士");

                    return new Warrior();
                // 冒險者類別新增時，需修改程式增加
                default:
                    return null;
            }
        }
    }
}
