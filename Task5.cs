namespace DZ7
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} і шириною {1}", height, width);
        }
    }

    class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }

    // Новий клас трикутник
    class Triangle : IFigure
    {
        int side1;
        int side2;
        int side3;

        public Triangle(int s1, int s2, int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public IFigure Clone()
        {
            return new Triangle(this.side1, this.side2, this.side3);
        }

        public void GetInfo()
        {
            Console.WriteLine("Трикутник зі сторонами {0}, {1}, {2}", side1, side2, side3);
        }
    }
}