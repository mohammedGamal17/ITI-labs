using System;

namespace ConsoleAppDealingWithAbstractCompanySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Clients Objects
            Client client1 = new Client(1, "client1", "Alexandria");
            Client client2 = new Client(2, "client2", "Cairo");
            Client client3 = new Client(3, "client3", "Mansoura");
            Client client4 = new Client(4, "client4", "Mansoura");
            Client client5 = new Client(5, "client5", "Mansoura");

            Client[] clients = { client1, client2, client3 };
            Client[] client = { client1, client2, client3, client4 };
            Client[] LongestClint = { client1, client2, client3, client4, client5 };
            #endregion

            #region HR
            HREmployee hr = new HREmployee(1, "HR1", 6000, clients);
            HREmployee hr2 = new HREmployee(1, "HR2", 6000, clients);

            Employee hr3 = hr + hr2;
            if (hr > hr2) { Console.WriteLine(hr.Name); }
            if (hr >= hr2) { Console.WriteLine(hr2.Name); }
            #endregion

            #region PR
            Employee pr = new PREmployee(1, "PR1", 7000, client);
            Employee pr2 = new PREmployee(1, "PR2", 7000, LongestClint);
            #endregion

            Employee[] employees = new Employee[] { hr, pr2, hr2 };

            Console.WriteLine(GetEmployeeWithLongestClientsArray(employees).Name);
            Console.ReadLine();
        }

        public static Employee GetEmployeeWithLongestClientsArray(Employee[] employee)
        {

            Employee emp = null;
            int checkForm = 0;

            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].Client.Length > checkForm)
                {
                    checkForm = employee[i].Client.Length;
                    emp = employee[i];
                }

            }
            return emp;
        }


    }
}
