namespace DZ7
{
    using System;
    using System.Collections.Generic;

    // Інтерфейс для геометричних фігур
    interface IGeometricShape
    {
        void Draw();
    }

    // Класи конкретних геометричних фігур
    class Circle1 : IGeometricShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    class Rectangle1 : IGeometricShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    // Клас композиту для геометричних фігур
    class CompositeShape : IGeometricShape
    {
        private List<IGeometricShape> shapes = new List<IGeometricShape>();

        public void AddShape(IGeometricShape shape)
        {
            shapes.Add(shape);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Composite Shape");
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    // Клас клієнта, який використовує геометричні фігури та їх композити
    class Client1
    {
        public void DrawShapes(IGeometricShape shape)
        {
            shape.Draw();
        }
    }

}
