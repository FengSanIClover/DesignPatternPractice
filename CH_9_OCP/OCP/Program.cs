using System;
using System.Collections.Generic;

namespace OCP
{
    class Program
    {
        private enum ShapeType
        {
            Circle = 1,
            Square = 2,
            Triangle = 3
        }

        static void Main(string[] args)
        {
            // 開放封閉原則範例
            Console.WriteLine("違反開放封閉原則範例-以列舉模擬類別");

            List<ShapeType> violation_shapes = 
                new List<ShapeType>() { ShapeType.Circle, ShapeType.Square,ShapeType.Triangle };

            Draw(violation_shapes);

            Console.WriteLine("如果下次再新增一個圖形-三角形，就必須修改程式");

            Console.WriteLine("");
            Console.WriteLine("遵守開放封閉原則範例");

            List<IShape> follow_shapes = new List<IShape>() { new Square(),new Triangle(),new Circle() };

            Draw(follow_shapes);

            Console.WriteLine("如果下次再新增一個圖形-三角形，就不須修改程式，只須透過新增類別的方式");
        }

        /// <summary>
        /// 繪製圖形-違反開放封閉原則
        /// </summary>
        /// <param name="shapes"></param>
        static void Draw(List<ShapeType> shapes)
        {
            foreach(ShapeType shape in shapes)
            {
                switch (shape)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("畫圓形");
                        break;
                    case ShapeType.Square:
                        Console.WriteLine("畫方形");
                        break;
                    //case ShapeType.Triangle:
                    //    Console.WriteLine("畫三角形");
                    //    break;
                }
            }
        }

        /// <summary>
        /// 繪製圖形-遵守開放封閉原則
        /// </summary>
        /// <param name="shapes"></param>
        static void Draw(List<IShape> shapes)
        {
            // 對圖形做排序-類別彼此之間都需知道對方，若有新增類別就要修改，違反原則
            // shapes.Sort();

            // 建立表格驅動的形狀類別排序機制
            shapes.Sort(new ShapeComparer());

            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
