using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    /// <summary>
    /// 撞擊攻擊-策略類別
    /// </summary>
    public class Tackle : ISkill
    {
        /// <summary>
        /// 專注於撞擊攻擊的邏輯-符合單一職責原則
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        public void Attack(Hero current, Hero target)
        {
            Console.WriteLine($"{current.Name}使用{this.ToString()}攻擊{target.Name}");

            target.LostHp(current.Strength - target.Defense);
        }

        public override string ToString()
        {
            return "撞擊";
        }
    }
}
