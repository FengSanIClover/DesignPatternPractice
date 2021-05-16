using SimpleFactory.Enums;
using SimpleFactory.Interface;
using SimpleFactory.Models;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("簡單工廠模式");
            // 訓練一個弓箭手
            IAdventurer archer = TrainingCamp.TrainAdventurer(AdventurerType.Archer);
            archer.ShowType();

            // 訓練一個鬥士
            IAdventurer warrior = TrainingCamp.TrainAdventurer(AdventurerType.Warrior);
            warrior.ShowType();
        }
    }
}
