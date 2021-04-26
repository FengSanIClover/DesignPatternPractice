using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Strategy.Models
{
    /// <summary>
    /// 依技能名稱排序
    /// </summary>
    public class HeroComparerBySkillName : IComparer<Hero>
    {
        public int Compare(Hero x, Hero y)
        {
            if(
                Char.ConvertToUtf32(x.SkillStrategy.ToString(),0) > Char.ConvertToUtf32(y.SkillStrategy.ToString(), 0)
              )
            {
                return 1; // x 要排在 y 前面
            }

            if (
                Char.ConvertToUtf32(x.SkillStrategy.ToString(), 0) < Char.ConvertToUtf32(y.SkillStrategy.ToString(), 0)
               )
            {
                return -1; // x 要排在 x 前面
            }

            return 0;　// 不動
        }
    }
}
