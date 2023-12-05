using DZ7;


class Program
{
    static void Main()
    {
        // Task4:
        IChristmasTree tree = new ChristmasTree();
        tree = new LightsDecorator(tree);
        tree = new OrnamentsDecorator(tree);

        tree.Display();

        // Task5:
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        IFigure figure = new Rectangle(10, 20);
        IFigure clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        figure = new Circle(15);
        clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        figure = new Triangle(10, 15, 20);
        clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        // Task6 Factory method:
        Client sedanClient = new Client(new SedanFactory());
        sedanClient.DriveAuto();

        Client suvClient = new Client(new SUVFactory());
        suvClient.DriveAuto();

        Client truckClient = new Client(new TruckFactory());
        truckClient.DriveAuto();

        // Task6 Composite:
        Circle1 circle1 = new Circle1();
        Rectangle1 rectangle1 = new Rectangle1();

        CompositeShape composite = new CompositeShape();
        composite.AddShape(circle1);
        composite.AddShape(rectangle1);

        Client1 client = new Client1();
        client.DrawShapes(circle1);
        client.DrawShapes(rectangle1);
        client.DrawShapes(composite);

        Console.ReadKey();
    }
}