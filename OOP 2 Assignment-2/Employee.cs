using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_Assignment_2
{

    public enum SecurityLevel{
        guest, Developer, secretary, DBA
    }

    

    public enum Gender
    {
        M,F
    }

    [Flags]
    public enum Permission:byte
    {
        Read = 1 << 0,  // 1
        Write = 1 << 1, // 2
        Delete = 1 << 2,// 4
        Execute = 1 << 3// 8
    }
    public class Employee
    {

        //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        public int ID;
        public string Name;
        public SecurityLevel SecurityLevel;
        public float Salary;
        public Gender Gender;
        public HireDate hireDate;
        public Permission permission;



        public Employee(int ID,string Name, SecurityLevel securityLevel,float Salary,Gender gender,HireDate hireDate,Permission permission) 
        {
            this.ID = ID;
            this.Name = Name;   
            this.SecurityLevel = securityLevel; 
            this.Salary = Salary;
            this.Gender = gender;
            this.hireDate = hireDate;
            this.permission = permission;
        }


        public int getID() {return this.ID;}
        public string getName() {return this.Name;}
        public SecurityLevel getSecurityLevel() {return this.SecurityLevel;}  
        public float getSalary() { return this.Salary;}
        public Gender getGender() { return this.Gender; }
        public HireDate getHireDate() {return this.hireDate;}
        public Permission getPermission() {return this.permission;} 

        override
        public string ToString()
        {
            Console.WriteLine("===   XXX   ===");
            return $"Employee ID: {this.ID}\nEmployee Name: {this.Name}\nEmployee SecurityLevel: {this.SecurityLevel}\nEmployee Salary: {string.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}\nEmployee Gender: {this.Gender}\nEmployee Hire Date: {this.hireDate}\nEmployee Permissions{permission}";
        }
    }
}
