using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_part_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Teacher teacher1 = new Teacher("Krasimir", "Zdravkov", 12, "Masaj Specialist");
            Console.WriteLine(teacher1.SayHello());
            Console.WriteLine(teacher1.CheckHomeworks());

            
            Lecturer lecturer1 = new Lecturer("Ganchev", "Kineziterapevt", -18, "Medical University Sofia");
            Console.WriteLine(lecturer1.ExercisesConduct(lecturer1.FirstName, lecturer1.LastName));
            Console.WriteLine(lecturer1.ExercisesConduct(lecturer1.FirstName));
            Console.WriteLine(lecturer1.ExercisesConduct());

            
            CollegeTeacher colTeacher = new CollegeTeacher();
            colTeacher.FirstName = "Nikolai";
            colTeacher.LastName = "Popov";
            colTeacher.College = "NCA";
            Console.WriteLine(colTeacher.CheckHomeworks());
            Console.WriteLine();

            
            SchoolTeacher schoolTeacher = new SchoolTeacher();
            schoolTeacher.FirstName = "Gergana";
            schoolTeacher.LastName = "Iordanova";
            schoolTeacher.Classes = new string[] { "1A", "1B", "1C", "1D", "1E" };
            schoolTeacher.EntertainChildren();
            Console.WriteLine("These are the classes:");
            schoolTeacher.SayClasses();

            
            Console.WriteLine();
            Proffesor professor = new Professor();
            professor.FirstName = "Boyan";
            professor.LastName = "Boyanov";
            professor.WorkingYears = 33;
            professor.Title = "Chemistry Professor";
            professor.SayTitle();
            professor.ExaminationConduct();
            professor.CheckHomeworks();

           
            Console.WriteLine();
            Assistant assistant = new Assistant();
            assistant.FirstName = "Nicolas";
            assistant.LastName = "Doskov";
            assistant.WorkingYears = 15;
            assistant.IsChiefAssistant = true;
            assistant.SayDetails();
            assistant.WriteArticles();
            assistant.PrintCounter();
            assistant.CheckHomeworks();
        }
    }
}
