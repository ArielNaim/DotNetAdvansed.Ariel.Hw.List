using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvansed.Ariel.Hw.List
{
    public static class ExtansionsForBeginners
    {
        #region Extansion 1
        public static bool HasLowerChars(this string chaekLower)
        {
            foreach (var ch in chaekLower)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Extnsion 2
        public static string ReveseCase(this string changLatters)
        {
            var str = "";
            foreach (var ch in changLatters)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    str += ch.ToString().ToUpper();
                }
                else
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        str += ch.ToString().ToLower();
                    }
                }
            }
            return str;
        }
        #endregion
        #region Extansion 3

        public static string Print(this int number)
        {
            string[] dozens = new string[] { "", "twenty", "thirty", " forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] oneness = new string[] { "", "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] tens = new string[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string adKan = "Ad Kan";
            if (number > 100) return adKan;
            if (number >= 0 && number <= 10)
            {
                return oneness[number + 1];
            }
            if (number > 10 && number < 20)
            {
                return $"{tens[(number % 10) - 1]}";
            }
            if (number >= 20 && number < 100 && number % 10 == 0) // בדיקה האם המספר הוא עשרות בלבד
            {
                return $"{dozens[(number / 10) - 1]}";
            }
            if (number >= 20 && number < 100 && number % 10 != 0)
            {
                return $"{dozens[(number / 10) - 1]} {oneness[(number % 10) + 1]}";
            }
            else return "one handred";
        }
        #endregion
        #region Extansion 4
        public static int MultiplayBY(this int num, int multyply)
        {
            return num * multyply;
        }
        #endregion
        #region Extansion 5
        public static bool IsNull(this object obj)
        {
            if (obj == null)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Extansions 6

        public static string GetIdNumber(string idConvert) // נגדיר פונקצית ביניים המחזירה את מספר הזהות בצורת מספר בעל 9 ספרות בכל מצב גם אם נקבל מספר ארוך מ 9 ספרות 

        {
            if (idConvert.Length > 9)
            {
                return Convert.ToString(000000001);
            }
            if (idConvert.Length < 9)
            {
                for (int i = 0; idConvert.Length < 9; i++)
                {
                    idConvert = "0" + idConvert;
                }
                return Convert.ToString(idConvert);
            }
            return Convert.ToString(idConvert);
        }


        public static bool IsValidIsraeliIdNumber(this string id)
        {
            int sum = 0;
            string charId;
            string idForCheck = Convert.ToString(GetIdNumber(id)); // נגדיר משתנה סטרינג שאיתו נעבוד לצורך הנוחות
            int counter = 1;
            string temp;

            foreach (char ch in idForCheck)
            {
                charId = Convert.ToString(ch);

                if (counter % 2 != 0) // כאשר המונה איי זוגי הספרה תוכפל ב 1 ותתוסף לסכום הכללי
                {
                    sum += Convert.ToInt32(charId);
                }

                if (counter % 2 == 0) // כאשר המונה זוגי המספר יוכפל ב 2 
                {
                    if ((Convert.ToInt32(charId) * 2) > 9) // אם המספר גדול מ 9 יש צורך לסכום את הספרות 
                    {
                        temp = Convert.ToString(Convert.ToInt32(charId) * 2);
                        sum += (Convert.ToInt32(Convert.ToString(temp[0]))) + (Convert.ToInt32(Convert.ToString(temp[1])));
                    }
                    else
                    {
                        sum += (Convert.ToInt32(charId) * 2);
                    }
                }
                counter++;

            }
            if (sum % 10 == 0)
            {
                return true;
            }
            return false;
        }
        #endregion
    }

}






