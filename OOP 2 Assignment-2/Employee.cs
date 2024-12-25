using System;
using System.Collections.Generic;
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
    public class Employee
    {

        //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        public int ID
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.ID = value;
            }
        }
        public string Name;
        public SecurityLevel SecurityLevel;
        public float Salary;
        public Gender Gender;
        public HireDate hireDate;



        public Employee(int ID,string Name, SecurityLevel securityLevel,float Salary,Gender gender,HireDate hireDate) 
        {
            this.ID = ID;
            this.Name = Name;   
            this.SecurityLevel = securityLevel; 
            this.Salary = Salary;
            this.Gender = gender;
            this.hireDate = hireDate;
        }


        public int getID() {return this.ID;}
        public string getName() {return this.Name;}
        public SecurityLevel getSecurityLevel() {return this.SecurityLevel;}  
        public float getSalary() { return this.Salary;}
        public Gender getGender() { return this.Gender; }
        public HireDate getHireDate() {return this.hireDate;}


    }
}
