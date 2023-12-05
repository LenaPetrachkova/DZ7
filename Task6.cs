namespace DZ7
{
    // Factory Method:
    // Інтерфейс для автомобілів
    interface IAuto
    {
        void Drive();
    }

    // Конкретні класи автомобілів
    class Sedan : IAuto
    {
        public void Drive()
        {
            Console.WriteLine("Sedan is driving.");
        }
    }

    class SUV : IAuto
    {
        public void Drive()
        {
            Console.WriteLine("SUV is driving.");
        }
    }

    class Truck : IAuto
    {
        public void Drive()
        {
            Console.WriteLine("Truck is driving.");
        }
    }

    // Інтерфейс фабрики автомобілів
    interface IAutoFactory
    {
        IAuto CreateAuto();
    }

    // Конкретні фабрики для кожного типу автомобіля
    class SedanFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            return new Sedan();
        }
    }

    class SUVFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            return new SUV();
        }
    }

    class TruckFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            return new Truck();
        }
    }

    // Клас клієнта, який використовує фабричний метод
    class Client
    {
        private IAutoFactory autoFactory;

        public Client(IAutoFactory factory)
        {
            autoFactory = factory;
        }

        public void DriveAuto()
        {
            IAuto auto = autoFactory.CreateAuto();
            auto.Drive();
        }
    }

}
