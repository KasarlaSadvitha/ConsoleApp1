namespace AbstractAssignment2
{
    abstract class Employee
    {
        public abstract void Duties();
        public abstract int TotalSalaryM();


        //public abstract virtual string Print();

        public string _empName;
        public int _basic, _da, _hra, TotalSalary;


        public int TotalSalaryProp
        {
            get { return this.TotalSalary; }
        }


        public Employee(string name, int basic, int da, int hra)
        {

            this._empName = name;
            this._basic = basic;
            this._da = da;
            this._hra = hra;

            this.TotalSalary = basic + da + hra;
        }

        //TotalSalary : Converting Method to Property


    }
    class DailyWorker : Employee
    {
        private int _DWAllowance;

        public DailyWorker(string name, int basic, int da, int hra, int allowance) : base(name, basic, da, hra)
        {
            this._DWAllowance = allowance;
        }


        public override void Duties()
        {
            Console.WriteLine("Physical work");
        }
        public override int TotalSalaryM()
        {
            return base.TotalSalaryProp + this._DWAllowance;
        }



    }
    class SoftwareEngineer : Employee
    {



        private int _SEAllowance;

        public SoftwareEngineer(string name, int basic, int da, int hra, int allowance) : base(name, basic, da, hra)
        {
            this._SEAllowance = allowance;
        }

        public override void Duties()
        {
            Console.WriteLine("Mental Work");
        }

        public override int TotalSalaryM()
        {
            return base.TotalSalaryProp + this._SEAllowance;
        }


    }
    class MainClass
    {
        public static void Main(string[] args)
        {

            Employee[] emps = new Employee[2];
            emps[0] = new DailyWorker("sony", 2, 3, 4, 5);
            emps[1] = new SoftwareEngineer("sony", 2, 3, 4, 5);

            foreach (Employee e in emps)
            {
                e.Duties();
                Console.WriteLine(e.TotalSalaryM());
            }
        }
    }
}