using System;

namespace ConsoleAppDealingWithStruct
{
    #region Structs

    #region Company
    struct Company
    {
        #region Fields
        private string name;
        private Department[] departments;
        #endregion

        #region Constructor
        public Company(string _name, Department[] _departments)
        {
            name = _name;
            departments = _departments;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Department[] Departments
        {
            get { return departments; }
            set { departments = value; }
        }
        #endregion

        #region Methods
        public string Print()
        {
            string allDep = "";

            foreach (var department in departments) { allDep += department.Print() + "\n"; }
            return $"Company name: {name}.\n\tDepartments:\n{allDep}";
        }
        #endregion

        #region Indexers
        public string this[string _depName]
        {
            get
            {
                for (int i = 0; i < Departments.Length; i++)
                {
                    if (Departments[i].DeptName.ToLower() == _depName.ToLower()) return Departments[i].DeptName;

                }
                return $"No Results for this {_depName}";
            }
            set
            {
                for (int i = 0; i < Departments.Length; i++)
                {
                    if (Departments[i].DeptName.ToLower() == _depName.ToLower())
                    {
                        Departments[i].Manager = value;
                    }
                }
            }
        }
        #endregion
    }
    #endregion

    #region Depertment
    struct Department
    {
        #region Fields
        string deptName;
        string manager;
        Employees[] employees;
        #endregion

        #region Constructor
        public Department(string _deptName, string _manager, Employees[] _employees)
        {
            deptName = _deptName;
            manager = _manager;
            employees = _employees;
        }
        #endregion

        #region Properties
        public string DeptName
        {
            set
            {
                if (value != null && value.Trim().Length != 0 && value.Trim().Length > 1) deptName = value;

            }
            get
            {
                return deptName;
            }
        }

        public string Manager
        {
            set
            {
                if (value != null && value.Trim().Length != 0) manager = value;

            }
            get
            {
                return manager;
            }
        }

        public Employees[] Employees
        {
            set
            {
                employees = value;

            }
            get
            {
                return employees;
            }
        }
        #endregion

        #region Methodes
        public string Print()
        {
            string allEmployess = "";
            for (int i = 0; i < Employees.Length; i++)
            {
                allEmployess += Employees[i].Print() + "\n";
            }
            return $"\t\tDepartment name : {DeptName}, Department Manager: {Manager},\n\t\t\tEmployees:\n{allEmployess}";
        }
        #endregion

        #region Indexers
        public string this[int _empLoyeeId]
        {
            set
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].ID == _empLoyeeId)
                    {
                        DeptName = value;
                        break;
                    }
                }
            }
            get
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].ID == _empLoyeeId)
                    {
                        return DeptName;
                    }
                }
                return $"No Recourds {_empLoyeeId}";
            }

        }
        #endregion
    }
    #endregion

    #region Employee
    struct Employees
    {
        #region Fields
        int id;
        string name;
        int securityLevel;
        int salary;
        HiringDate hireDate;
        string gender;
        #endregion

        #region Constructor
        public Employees(int _id, string _name, int _securityLevel, int _salary, HiringDate _hireDate, string _gender)
        {
            id = _id;
            name = _name;
            securityLevel = _securityLevel;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
        }
        #endregion

        #region Properties
        public int ID
        {
            set
            {
                if (value > 0) id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                if (value != null && value.Trim().Length != 0) name = value;
            }
            get
            {
                return name;
            }

        }
        public int SecurityLevel
        {
            set
            {
                if (value > 0 && value <= 10)
                {
                    securityLevel = value;
                }
            }
            get
            {
                return securityLevel;
            }
        }
        public int Salary
        {
            set
            {
                if (value > 0 && value <= 5000) salary = value;
            }
            get
            {
                return salary;
            }
        }
        public HiringDate HireDate
        {
            set
            {
                hireDate = value;
            }
            get
            {
                return hireDate;
            }
        }
        public string Gender
        {
            set
            {
                value.ToLower();
                switch (value)
                {
                    case "male":
                        gender = value;
                        break;
                    case "female":
                        gender = value;
                        break;
                    case "":
                    case " ":
                        gender = "male";
                        break;
                    default:
                        gender = "male";
                        break;
                }
            }
            get
            {
                return gender;
            }
        }
        #endregion

        #region Methods
        public string Print()
        {
            return $"\t\t\t\tEmp Id :{ID} , Name: {Name} , securityLevel: {SecurityLevel} ,{hireDate.displayDate()} , Gender: {Gender}";
        }
        #endregion
    }
    #endregion

    #region Hiring Date
    struct HiringDate
    {
        #region Fields
        int day;
        int month;
        int year;
        #endregion

        #region Constructor
        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }

        #endregion

        #region Properties
        public int Day
        {
            set
            {
                if (value > 0 && value <= 31) day = value;
            }
            get
            {
                return day;
            }
        }
        public int Month
        {
            set
            {
                if (value > 0 && value <= 12) month = value;
            }

            get
            {
                return month;
            }

        }
        public int Year
        {
            set
            {
                if (value > 1980 && value <= DateTime.Today.Year) year = value;
            }
            get
            {
                return year;
            }
        }
        #endregion

        #region Methods
        public string displayDate()
        {
            return $"hiring Date: {Day} - {Month} - {Year}";
        }
        #endregion

    }
    #endregion

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Console.Write("Enter Your Company Name: ");
            company.Name = Console.ReadLine();


            Console.Write("Enter Number Of Company Department: ");
            int numberOfDep = int.Parse(Console.ReadLine());

            company.Departments = new Department[numberOfDep];
            // Insert In Depertment
            for (int i = 0; i < numberOfDep; i++)
            {
                Console.WriteLine($"\nDepartment {i + 1}");

                company.Departments[i] = new Department();

                Console.Write($"Enter {i + 1} DeptName: ");
                string depName = Console.ReadLine();

                foreach (Department department in company.Departments)
                {
                    while (department.DeptName == depName)
                    {
                        Console.WriteLine("This department has created!!");
                        Console.Write($"Please Write {i + 1} Departement again: ");
                        depName = Console.ReadLine();
                    }
                    company.Departments[i].DeptName = depName;
                }

                Console.Write($"Enter {i + 1} Manager Name: ");
                company.Departments[i].Manager = Console.ReadLine();
                _initEmployee(company, i, depName);


                Console.WriteLine("\n\t**********************************");
            }

            //Console.WriteLine(company.Print());
            _getAllDepartments(company);
            _CountAllEmplyee(company);

            Console.Clear();

            _searchForEmployee(company);
            _updateEmplyee(company);
            _searchForEmployee(company);
            Console.ReadKey();
        }

        private static void _initEmployee(Company company, int i, string depName)
        {
            Console.Write($"Enter Number of Employee in {i + 1} dept: ");
            int numberOfEmployee = int.Parse(Console.ReadLine());
            company.Departments[i].Employees = new Employees[numberOfEmployee];

            int totalNumberOfEmplyee = 0;

            // Insert In Employee
            for (int j = 0; j < numberOfEmployee; j++)
            {
                Console.WriteLine($"Employee {j + 1}");

                company.Departments[i].Employees[j].ID = _setEmployeeId(company, i, j);

                company.Departments[i].Employees[j].Name = _setEmployeeName(company, i, j);

                company.Departments[i].Employees[j].SecurityLevel = _setEmployeeSecurityLevel(company, i, j);

                company.Departments[i].Employees[j].Salary = _setEmployeeSalary(company, i, j);

                _setEmployeeHiringDate(company, i, j);

                company.Departments[i].Employees[j].Gender = _setEmployeeGender(company, i, j);


                totalNumberOfEmplyee++;

                Console.WriteLine();
            }
            Console.WriteLine(_getCountEmployeeInDepartment(depName, numberOfEmployee));
            Console.WriteLine(totalNumberOfEmplyee);
        }
        private static int _setEmployeeId(Company company, int i, int j)
        {
            Console.Write($"\tEnter {j + 1} Employee ID: ");
            int empID = int.Parse(Console.ReadLine());
            foreach (var emp in company.Departments[i].Employees)
            {
                while (emp.ID == empID)
                {
                    Console.WriteLine("THIS ID IS INVALID");
                    Console.Write($"Please Write Other ID for Employee{j + 1}: ");
                    empID = int.Parse(Console.ReadLine());
                }
            }

            return empID;
        }
        private static string _setEmployeeName(Company company, int i, int j)
        {
            Console.Write($"\tEnter {j + 1} Employee Name: ");
            return Console.ReadLine(); ;
        }
        private static int _setEmployeeSecurityLevel(Company company, int i, int j)
        {
            Console.Write($"\tEnter {j + 1} Employee SecurityLevel: ");
            return int.Parse(Console.ReadLine());
        }
        private static int _setEmployeeSalary(Company company, int i, int j)
        {
            Console.Write($"\tEnter {j + 1} Employee Salary: ");
            return int.Parse(Console.ReadLine());
        }
        private static void _setEmployeeHiringDate(Company company, int i, int j)
        {
            Console.Write($"\tEnter {j + 1} Employee Hiring day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write($"\tEnter {j + 1} Employee Hiring month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write($"\tEnter {j + 1} Employee Hiring year: ");
            int year = int.Parse(Console.ReadLine());
            company.Departments[i].Employees[j].HireDate = new HiringDate(day, month, year);
        }
        private static string _setEmployeeGender(Company company, int i, int j)
        {
            Console.Write("\tEnter Employee Gender: ");
            return Console.ReadLine().ToLower();
        }

        private static string _getCountEmployeeInDepartment(string depName, int numberOfEmployee)
        {
            return $"in Department: {depName} number of employee is {numberOfEmployee}";
        }
        private static void _getAllDepartments(Company company)
        {
            if (company.Departments != null)
            {
                Console.WriteLine("Departments");
                for (int i = 0; i < company.Departments.Length; i++)
                {
                    Console.WriteLine($" {i + 1} - {company.Departments[i].DeptName}");
                }
            }
            else
            {
                Console.WriteLine("No Department yet!.");
            }

        }
        private static int _CountAllEmplyee(Company company)
        {
            if (company.Departments != null)
            {
                int numOfEmp = 0;

                for (int i = 0; i < company.Departments.Length; i++)
                {
                    numOfEmp += company.Departments[i].Employees.Length;
                }
                Console.WriteLine($"Total Employee {numOfEmp}");
                return numOfEmp;
            }
            Console.WriteLine("No Department yet!.");
            return 0;

        }

        private static void _searchForEmployee(Company company)
        {
            Console.WriteLine("SEARCH");
            Console.Write("Enter Department name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter Employee ID: ");
            int EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine(_searchForEmployeeId(company, EmpId, deptName));
        }
        private static string _searchForEmployeeId(Company company, int id, string deptName)
        {

            foreach (Department department in company.Departments)
            {
                if (department.DeptName.ToLower() == deptName.ToLower())
                {
                    foreach (Employees employee in department.Employees)
                    {
                        if (employee.ID == id)
                        {
                            return $"Employee Id: {employee.ID}, Name: {employee.Name}, Salary: {employee.Salary}, Gender:{employee.Gender}";
                        }
                    }
                }
            }
            return "No Result";
        }


        public static void _updateEmplyee(Company company)
        {
            Console.WriteLine("SEARCH");
            Console.Write("Enter Department name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter Employee ID: ");
            int EmpId = int.Parse(Console.ReadLine());
            _updateEmployeeName(company, EmpId, deptName);
        }

        public static Company _updateEmployeeName(Company company, int id, string deptName)
        {
            for (int i = 0; i < company.Departments.Length; i++)
            {
                Department department = company.Departments[i];
                if (department.DeptName.ToLower() == deptName.ToLower())
                {
                    for (int j = 0; j < department.Employees.Length; j++)
                    {
                        Employees employee = department.Employees[j];

                        if (employee.ID == id)
                        {
                            Console.Write("Enter New Name: ");
                            string newName = Console.ReadLine();
                            Console.WriteLine("*Updated*\n");
                            employee.Name = newName;
                            return company;
                        }
                    }
                }
            }
            return company;
        }
    }
}
