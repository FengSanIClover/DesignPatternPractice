using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    /// <summary>
    /// 打雷攻擊-策略類別
    /// </summary>
    public class Thunder : ISkill
    {
        /// <summary>
        /// 專注於打雷攻擊的邏輯-符合單一職責原則
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        public void Attack(Hero current, Hero target)
        {
            Console.WriteLine($"{current.Name}使用打雷攻擊{target.Name}");

            current.LostMP(5);

            target.LostHp(current.Wisdom * 2);
        }

        public override string ToString()
        {
            return "打雷";
        }
    }

    /// <summary>
    /// 打雷攻擊-策略類別
    /// </summary>
    public class CopyOfThunder : ISkill
    {
        /// <summary>
        /// 專注於打雷攻擊的邏輯-符合單一職責原則
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        public void Attack(Hero current, Hero target)
        {
            Console.WriteLine($"{current.Name}使用打雷攻擊{target.Name}");

            current.LostMP(5);

            target.LostHp(current.Wisdom * 2);
        }

        public override string ToString()
        {
            return "打雷";
        }
    }
}
