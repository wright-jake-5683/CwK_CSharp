namespace Intro_To_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IEmployee
    {
        public void Salary();
        public void Manager();
    }

    interface IDepartment
    {
        public void DepartmentCode();
        public void Project();
    }

    public class NewEmployee : IEmployee, IDepartment
    {
        public void Salary()
        {
            Console.WriteLine("Code that would return salaray goes here");
        }

        public void Manager()
        {
            Console.WriteLine("Code that would return manager goes here");
        }

        public void DepartmentCode()
        {
            Console.WriteLine("Code that would return department code goes here");
        }

        public void Project()
        {
            Console.WriteLine("Code that would return current project goes here");
        }
    }
}