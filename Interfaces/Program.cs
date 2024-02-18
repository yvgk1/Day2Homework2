namespace Interfaces
{
    class Program
    {
        //interfaces new'lenemez
        static void Main(string[] args)
        {
            //interfaceler onu implement eden classın referansını tutabilirler
            IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Mğşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi.");
        }
    }

    class InternManager : IPersonManager

    {
        public void Add()
        {
            Console.WriteLine("Inter Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Intern Gğncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }
}