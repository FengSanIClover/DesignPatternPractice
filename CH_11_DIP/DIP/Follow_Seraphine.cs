using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    /// <summary>
    /// 瑟菈紛類別繼承 LOL 角色介面，並實作方法
    /// </summary>
    class Follow_Seraphine : ILOLCharacter
    {
        public void Attack()
        {
            Console.WriteLine("瑟菈紛攻擊");
        }
    }
}
