using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("依賴反轉原則範例");
            // 建立艾希類別並呼叫方法
            // Client Class(Program) 裡面直接與艾希這個 claas 耦合，這個動作就違反了 DIP。
            Ashe ashe = new Ashe();
            ashe.Attack();

            // 若要改為使用 瑟菈紛 就必須修改程式，違反 OCP
            // 因為高層模組(也就是 Program)，希望使用的角色，依賴於低層模組 (艾希、瑟菈紛)。
            Seraphine seraphine = new Seraphine();
            seraphine.Attack();

            // 依賴反轉在這個 case 的重點，就是讓原本 Program 依賴於細節 class，改成細節 class 依賴於抽象介面。
            ILOLCharacter character = GetCharacter(CharacterType.Seraphine);
            character.Attack();

            // 高層模組要的是抽象化的行為與邏輯，我們 care 的是，要使用的角色(interface/abstract)。
            // 用什麼(concrete class)角色類別，則不會影響我們 Program 的抽象邏輯(使用的角色)。
        }

        /// <summary>
        /// 取得對應角色的工廠模式
        /// </summary>
        /// <param name="characterType"></param>
        /// <returns></returns>
        static ILOLCharacter GetCharacter(CharacterType characterType)
        {
            switch (characterType)
            {
                case CharacterType.Ashe:
                    return new Follow_Ashe();
                case CharacterType.Seraphine:
                    return new Follow_Seraphine();
                default:
                    return null;
            }
        }

        /// <summary>
        /// 角色 Enum
        /// </summary>
        enum CharacterType
        {
            Ashe = 1,
            Seraphine = 2
        }
    }
}
