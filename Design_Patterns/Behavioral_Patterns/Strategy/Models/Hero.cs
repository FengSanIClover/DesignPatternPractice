using Strategy.Const;
using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    /// <summary>
    /// 英雄類別
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 血量
        /// </summary>
        public int HP { get; set; } = 100;

        /// <summary>
        /// 魔力
        /// </summary>
        public int MP { get; set; } = 200;

        /// <summary>
        /// 力量
        /// </summary>
        public int Strength { get; set; } = 20;

        /// <summary>
        /// 智力
        /// </summary>
        public int Wisdom { get; set; } = 20;

        /// <summary>
        /// 防禦值
        /// </summary>
        public int Defense { get; set; } = 5;

        /// <summary>
        /// 技能
        /// </summary>
        public Skill Skill { get; set; }

        /// <summary>
        /// 技能-套用策略模式
        /// </summary>
        public ISkill SkillStrategy { get; set; }

        /// <summary>
        /// 是否使用策略模式
        /// </summary>
        public bool IsStrategy { get; set; } = false;

        public Hero(string name,Skill skill)
        {
            this.Name = name;
            this.Skill = skill;
        }

        public Hero(string name, ISkill skill)
        {
            this.Name = name;
            this.SkillStrategy = skill;
            this.IsStrategy = true;
        }

        /// <summary>
        /// 攻擊對方英雄的方法
        /// </summary>
        /// <param name="targetHero"></param>
        public void Attack(Hero targetHero)
        {
            if (this.IsStrategy)
            {
                this.StrategyAttack(targetHero);

                return;
            }

            this.NormalAttack(targetHero);
        }

        /// <summary>
        /// 未套用策略模式的攻擊方法
        /// </summary>
        /// <param name="targetHero"></param>
        private void NormalAttack(Hero targetHero)
        {
            switch (this.Skill)
            {
                case Skill.Tackle:
                    Console.WriteLine($"{this.Name}使用撞擊攻擊{targetHero.Name}");

                    targetHero.LostHp(this.Strength - targetHero.Defense);

                    this.ShowTargetInfo(targetHero);
                    break;
                case Skill.Thunder:
                    Console.WriteLine($"{this.Name}使用打雷攻擊{targetHero.Name}");

                    this.LostMP(5);

                    targetHero.LostHp(this.Wisdom * 2);

                    this.ShowTargetInfo(targetHero);
                    break;
                    // 多個技能必須改寫程式碼
            }
        }

        /// <summary>
        /// 套用策略模式的攻擊方法
        /// </summary>
        /// <param name="targetHero"></param>
        private void StrategyAttack(Hero targetHero)
        {
            // 將攻擊的責任委派給 技能類別(給予適當資訊)
            this.SkillStrategy.Attack(this, targetHero);
            this.ShowTargetInfo(targetHero);
        }

        /// <summary>
        /// 受到傷害，損失生命值
        /// </summary>
        /// <param name="val">損失值</param>
        /// <returns></returns>
        public void LostHp(int val)
        {
            Console.WriteLine($"{this.Name}受到攻擊，損失:{val}點生命值。");
            this.HP -= val;
        }

        /// <summary>
        /// 使用法術-損失魔力值
        /// </summary>
        /// <param name="val">損失值</param>
        /// <returns></returns>
        public void LostMP(int val)
        {
            Console.WriteLine($"{this.Name}使用魔法攻擊，損失:{val}點魔力。");
            this.MP -= val;
        }

        /// <summary>
        /// 判斷是否 HP > 0
        /// </summary>
        /// <returns></returns>
        public bool IsAlive()
        {
            return this.HP > 0;
        }

        /// <summary>
        /// 顯示受攻擊英雄資訊
        /// </summary>
        /// <param name="targetHero"></param>
        public void ShowTargetInfo(Hero targetHero)
        {
            if(targetHero.HP > 0)
            {
                Console.WriteLine($"{targetHero.Name}剩餘{targetHero.HP}生命值");
                return;
            }

            Console.WriteLine($"{targetHero.Name}剩餘{0}生命值");
        }
    }
}
