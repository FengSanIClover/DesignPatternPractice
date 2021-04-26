using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Interface
{
    /// <summary>
    /// 技能介面
    /// </summary>
    public interface ISkill
    {
        /// <summary>
        /// 使用技能攻擊
        /// </summary>
        /// <param name="current">當前英雄</param>
        /// <param name="target">對方英雄</param>
        void Attack(Hero current, Hero target);
    }
}
