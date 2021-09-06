using System;
using System.Collections.Generic;

namespace DotNetAdvansed.Ariel.Hw.List
{
    class Program
    {
        public static List<Student> studentList = new List<Student>(100);
        public static List<TemperatureMeasurement> TempMeasList = new List<TemperatureMeasurement>();
        static void PrintAll<T>(List<T> list) // פונקציה הדפסב גנרית לצורך בדיקת התוצאות, מתאים לשימוש בכל אחת מהמחלקות השונות 
        {
            foreach (var itam in list)
            {
                Console.WriteLine(itam);
            }
        }

        static void Main(string[] args)
        {
           

            #region Extensions For Beginners 
            string id = "890500";
            int nu = 5;// var forTargil 3 + 4
            var charCheck = "aRIEL"; // var for Targil 1+2
            string[] nullObj = new string[] { "cool" }; // var for targil 5
            Console.WriteLine(charCheck.HasLowerChars()); // Targil 1
            Console.WriteLine(charCheck.ReveseCase());// Targil 2
            Console.WriteLine(nu.Print()); // Targil 3
            Console.WriteLine(nu.MultiplayBY(3));// Targil 4
            if (nullObj.IsNull()) // Targil 5 
            {
                Console.WriteLine("null");
            }
            Console.WriteLine("not null"); //end of Targil 5

            Console.WriteLine(id.IsValidIsraeliIdNumber()); // Targil 6
           
            #endregion
          
             #region List Targil 1 Student
            
              studentList.Add(new Student("Ariel", "Naim", 85));
              studentList.Add(new Student("Noam", "Mizrahy", 76));
              studentList.Add(new Student("Sara", "Galger", 90));
              studentList.Add(new Student("Nitzan", "Katz", 80));
              studentList.Add(new Student("beny", "Katz", 80));

              PrintAll(studentList);
              Console.WriteLine("");
              studentList.Sort();
              studentList.Sort(new SortByGrade());
              PrintAll(studentList);
              #endregion

              #region List Targil 2 - Temperature

              TempMeasList.Add(new TemperatureMeasurement("Tel Aviv", 13.02, 33, 90));
              TempMeasList.Add(new TemperatureMeasurement("Kfar Sabe", 15.02, 31, 85));
              TempMeasList.Add(new TemperatureMeasurement("kfar Tavor", 15.02, 29, 55));
              TempMeasList.Add(new TemperatureMeasurement("kfar Ssba", 17.02, 26, 70));
              TempMeasList.Add(new TemperatureMeasurement("Nazhart", 01.02, 33, 85));
              TempMeasList.Add(new TemperatureMeasurement("Dimona", 21.02, 40, 15));
              TempMeasList.Add(new TemperatureMeasurement("dan", 22.02, 34, 85));

              PrintAll(TempMeasList);
              TempMeasList.Sort();
              Console.WriteLine("");
              TempMeasList.Sort(new SortByTempOrHumid());
              PrintAll(TempMeasList);
            
              #endregion
           


        }

    }
}
