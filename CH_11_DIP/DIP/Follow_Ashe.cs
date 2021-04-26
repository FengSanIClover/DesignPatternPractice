using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    /// <summary>
    /// 艾希類別繼承 LOL 角色介面，並實作方法
    /// </summary>
    class Follow_Ashe : ILOLCharacter
    {
        public void Attack()
        {
            Console.WriteLine("艾希攻擊");
        }
    }
}
