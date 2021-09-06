using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvansed.Ariel.Hw.List
{
    class SortByGrade : IComparer<Student> // ניצור מחקה ממינת לפי ציון בסדר יורד
    {
        public int Compare(Student x, Student y)
        {
            return (x.Grade.CompareTo(y.Grade) * -1); // מיון הסטודנטים בסדר יורד מתקבל ע"י הכפלה ב מינוס 
        }
    }
}
