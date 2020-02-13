using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssign
{
    public interface IStudent
    {
     
        string Name
        {
            get;
            set;
        }
        int StudentId
        {
            get;
            set;
        }
        void ShowDetails();
        
    }
   class Dayscholar:IStudent
    {
        string name;
        int id;
       string IStudent.Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        int IStudent.StudentId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public Dayscholar(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public void ShowDetails()
        {
            Console.WriteLine("\nStudent Name " + this.name + "\nId " +this.id);

        }
    }
    class Resident : IStudent
    {
        string name;
        int id;
        string IStudent.Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        int IStudent.StudentId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public Resident(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public void ShowDetails()
        {
            Console.WriteLine("\nResident Student Name " + this.name + "\nId " + this.id);

        }
    }
    }
