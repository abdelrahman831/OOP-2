
using OOP_2_Assignment_2;
using static OOP_2_Assignment_2.Employee;

namespace Assignment2
{

    class Assignment2
    {
        static void Main()
        {
            // PROBLEM 3
            Permission all = Permission.Read | Permission.Write | Permission.Delete | Permission.Execute;


            Employee e1 = new Employee(12,"Abdo",SecurityLevel.DBA,340000,Gender.M, new HireDate(2024, 12, 15), all);
            Employee e2 = new Employee(14, "Mohamed", SecurityLevel.guest, 2000, Gender.M, new HireDate(2034, 10, 12), all);

            Employee e3 = new Employee(33, "Gaber", SecurityLevel.secretary, 345000, Gender.M, new HireDate(2014, 2, 22), all);

            Employee[] Emp = new Employee[]{ e1, e2, e3 }; 

            Employee temp;

            for (int i = 0; i < Emp.Length; i++) 
            {
                for(int j = i+1;j<Emp.Length-1; j++)
                {
                    if (DateTime.Compare(Emp[i].hireDate.date, Emp[j].hireDate.date) < 0)
                    {
                        temp = Emp[i];
                        Emp[i] = Emp[j];
                        Emp[j] = temp;
                        Console.WriteLine("sorting");
                    }

                } 
            }

            for (int i = 0; i < Emp.Length; i++)
            {
                Console.WriteLine(Emp[i].ToString());

            }






        }
    }
}