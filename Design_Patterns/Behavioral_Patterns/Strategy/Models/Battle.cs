using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    /// <summary>
    /// 戰鬥用類別
    /// </summary>
    public class Battle
    {
        private Hero[] heros = new Hero[2];

        /// <summary>
        /// 傳入對戰英雄
        /// </summary>
        /// <param name="hero1"></param>
        /// <param name="hero2"></param>
        public Battle(Hero hero1,Hero hero2)
        {
            this.heros[0] = hero1;
            this.heros[1] = hero2;
        }

        /// <summary>
        /// 戰鬥開始
        /// </summary>
        public void Start()
        {
            Console.WriteLine("戰鬥開始");
            var count = 1;
            var currentIndex = 0;
            while (this.IsNewTurn())
            {
                Console.WriteLine($"開始第{count}回合戰鬥");
                Console.WriteLine("");

                var targetIndex = currentIndex == 0 ? 1 : 0;

                this.heros[currentIndex].Attack(this.heros[targetIndex]);

                currentIndex = currentIndex == 0 ? 1 : 0;

                Console.WriteLine("");
                Console.WriteLine($"結束第{count}回合戰鬥");
                count += 1;
            }

            Console.WriteLine("戰鬥結束");
        }

        /// <summary>
        /// 是否繼續新的一回合戰鬥
        /// </summary>
        /// <returns></returns>
        private bool IsNewTurn()
        {
            return this.heros[0].IsAlive() && this.heros[1].IsAlive();
        }
    }
}
