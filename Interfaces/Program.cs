namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler newlenemez.
            IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
        }
    }
}
