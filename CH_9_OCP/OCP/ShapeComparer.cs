using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OCP
{
    /// <summary>
    /// 隔離所有 Shape 的衍生類別，使它門互不知曉對方，再有新的類別加入時不須各個修改排序方法，形成封閉
    /// 這個比較程式用於從 priorities hashtable 中，搜尋某形狀。
    /// priorities hashtable 定義了圖形的先後順序，未存在的形狀會優先於其他已知的形狀
    /// </summary>
    public class ShapeComparer : IComparer<IShape>
    {
        private static Hashtable priorities = new Hashtable();

        static ShapeComparer()
        {
            priorities.Add(typeof(Circle), 1);
            priorities.Add(typeof(Square), 2);
            priorities.Add(typeof(Triangle), 3);
        }

        private int PriorityFor(Type type)
        {
            if (priorities.Contains(type))
                return (int)priorities[type];

            return 0;
        }

        /// <summary>
        /// 實作 IComparer 的比較方法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(IShape x, IShape y)
        {
            int priority1 = PriorityFor(x.GetType());
            int priority2 = PriorityFor(y.GetType());

            return priority1.CompareTo(priority2);
        }
    }
}
