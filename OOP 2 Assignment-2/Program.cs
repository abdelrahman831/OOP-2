
using OOP_2_Assignment_2;
using static OOP_2_Assignment_2.Employee;

namespace Assignment2
{

    class Assignment2
    {
        static void main()
        {
            HireDate hd;

            hd.SetDate(12, 13, 2004);


            Employee e = new Employee(12,"Abdo",SecurityLevel.Developer,123456,Gender.M,hd.ToString());







        }
    }
}