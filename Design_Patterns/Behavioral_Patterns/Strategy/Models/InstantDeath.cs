using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    /// <summary>
    /// 即死攻擊-策略類別
    /// </summary>
    public class InstantDeath : ISkill
    {
        /// <summary>
        /// 專注於即死攻擊的邏輯-符合單一職責原則
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        public void Attack(Hero current, Hero target)
        {
            Console.WriteLine($"{current.Name}使用{this.ToString()}攻擊{target.Name}");

            Random r = new Random();
            var val = r.Next(0, 10);

            var lostHp = val % 2 == 0 ? target.HP : 0;

            target.LostHp(lostHp);
        }

        public override string ToString()
        {
            return "即死攻擊";
        }
    }
}
