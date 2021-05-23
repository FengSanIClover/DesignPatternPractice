using Factory.Interface;
using Factory.Models;
using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("工廠模式");

            List<ITrainingCamp> trainCamps = new List<ITrainingCamp>() { new ArcherTrainCamp(),new WarriorTrainCamp()};

            foreach(ITrainingCamp trainCamp in trainCamps)
            {
                IAdventure adventure = trainCamp.TrainAdventure();
                adventure.ShowType();
            }
        }
    }
}
