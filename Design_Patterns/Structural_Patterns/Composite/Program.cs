using Composite.Interface;
using Composite.Models;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("組合模式");
            Console.WriteLine("");
            Association root = new Association("冒險者協會總會", "冒險者一切相關事務");
            root.departments.Add(new Department("總會-人力資源單位", "拐騙冒險者加入並完成任務"));
            root.departments.Add(new Department("總會-客服單位", "處理客戶與冒險者糾紛"));

            Association taipei = new Association("冒險者協會-台北分會", "台北地區冒險者一切相關事務");
            taipei.departments.Add(new Department("台北分會-人力資源單位", "台北地區拐騙冒險者加入並完成任務"));
            taipei.departments.Add(new Department("台北分會-客服單位", "台北地區處理客戶與冒險者糾紛"));
            root.departments.Add(taipei);
            Console.WriteLine("組織結構圖:");
            root.Display(1);
            Console.WriteLine("");
            Console.WriteLine("組織職責:");
            root.LineOfDuty();

        }
    }
}
