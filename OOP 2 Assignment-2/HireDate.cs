using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_Assignment_2
{
    public class HireDate : Employee 
    {

        public int day;
        public int month;
        public int year;
        public DateTime date;
        
        public HireDate(int ID, string Name, SecurityLevel securityLevel, float Salary, Gender gender, HireDate hireDate) : base(ID, Name, securityLevel, Salary, gender, hireDate)
        {


        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public void SetDate(int day,int month,int year)
        {
            date = new DateTime(this.day, this.month, this.year);
        }


        override
        public string ToString()
        {
            
            return date.ToString();
        }
    }
}
