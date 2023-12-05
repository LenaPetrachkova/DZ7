namespace DZ7
{
    // Component
    interface IChristmasTree
    {
        void Display();
    }

    // ConcreteComponent
    class ChristmasTree : IChristmasTree
    {
        public void Display()
        {
            Console.WriteLine("Plain Christmas Tree");
        }
    }

    // Decorator
    abstract class ChristmasTreeDecorator : IChristmasTree
    {
        protected IChristmasTree decoratedTree;

        public ChristmasTreeDecorator(IChristmasTree tree)
        {
            decoratedTree = tree;
        }

        public virtual void Display()
        {
            decoratedTree.Display();
        }
    }

    // ConcreteDecoratorA
    class OrnamentsDecorator : ChristmasTreeDecorator
    {
        public OrnamentsDecorator(IChristmasTree tree) : base(tree)
        {
        }

        public override void Display()
        {
            base.Display();
            AddOrnaments();
        }

        private void AddOrnaments()
        {
            Console.WriteLine(" + Ornaments");
        }
    }

    // ConcreteDecoratorB
    class LightsDecorator : ChristmasTreeDecorator
    {
        public LightsDecorator(IChristmasTree tree) : base(tree)
        {
        }

        public override void Display()
        {
            base.Display();
            AddLights();
        }

        private void AddLights()
        {
            Console.WriteLine(" + Lights");
        }
    }

}
