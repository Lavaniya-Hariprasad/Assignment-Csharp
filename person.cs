using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Csharp
{
    public abstract class Person  //abstract parent class
    {
        public string name { get; set; }
        public string department { get; set; }
        public int age { get; set; }

    }

    public class Staff : Person  // class Staff inherits class Person
    { 
        public float salary { get; set; }
        public string qualification { get; set; }


    }

    public class Student : Person  // class Student inherits class Person
    {
        public float cgpa { get; set; }

        public string rollno { get; set; }

        public Student(string name, string rollno, float cgpa)    // Constructor
        {
            this.name = name;
            this.cgpa = cgpa;
            this.rollno = rollno;
        }

        //write_exam() performs polymorphism
        public void write_exam (string hall_ticket)  
        {
            Console.WriteLine("Taking theory exam : " + hall_ticket);
        }
        public void write_exam(string hall_ticket, string record_number)
        {
            Console.WriteLine("Taking practical exam :" + hall_ticket + " " + record_number);
        }

        public void display_details () 
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("CGPA : " + cgpa);
            Console.WriteLine("Roll Number : " + rollno);
        }
    }


    //IDepartment interfaces Class Department and Class Subject
    public class Department : IDepartment
    {
        public string dept_id { get; set; }
        public string department_name { get; set; }
        public string hod_name { get; set; }

        public Department(string department_name)
        {
            this.department_name = department_name;
        }

        public void dept_name()
        {
            Console.WriteLine("Department is " + department_name);
        }
    }

    public class Subject : IDepartment
    {
        public string name { get; set; }

        public string type { get; set; }

        public string department_name { get; set; }
        public Subject(string department_name)
        {
            this.department_name = department_name;
        }

        public void dept_name()
        {
            Console.WriteLine("Department is " + department_name);
        }
    }

    public class University
    {
        public static void Main(String[] args)
        {
            Student S1 = new Student("Lavaniya","19I230", 9.0f );
            S1.write_exam("ht123");
            S1.write_exam("ht123", "rc234");
            S1.display_details();

            Department D1 = new Department("Information Technology");
            D1.dept_name();

            Subject subject = new Subject("Computer Science");
            subject.dept_name();

        }
    }

}
