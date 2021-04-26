using Strategy.Const;
using Strategy.Models;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("策略模式");
            // Hero alistar = new Hero("牛頭人", Skill.Tackle);
            // Hero kennen = new Hero("凱能", Skill.Thunder);
            // Battle battle = new Battle(alistar, kennen);

            Hero alistar = new Hero("牛頭人", new InstantDeath());
            Hero kennen = new Hero("凱能", new Thunder());

            Battle battle = new Battle(alistar, kennen);
            battle.Start();

            List<Hero> heros = new List<Hero>();
            heros.Add(kennen);
            heros.Add(alistar);

            Console.WriteLine("");
            Console.WriteLine("技能未排序");
            foreach (var hero in heros)
            {
                Console.WriteLine(hero.SkillStrategy.ToString());
            }

            Console.WriteLine("");

            Console.WriteLine("技能排序-策略模式");
            heros.Sort(new HeroComparerBySkillName());
            foreach(var hero in heros)
            {
                Console.WriteLine(hero.SkillStrategy.ToString());
            }
        }
    }
}
