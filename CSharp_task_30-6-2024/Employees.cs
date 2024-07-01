using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_task_30_6_2024
{
    /*5-	Create class that contain the following field:
             a.	Age  between 18-60
             b.	Gender
             c.	Name
             d.	E-Mail	
             e.	ID
             f.	Phoneshould be started in 077 or 078 or 079
             Don’t forget the default value.
        */
    public class Range
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }
        public bool IsWithinRange(int number)
        {
            return number >= Start && number <= End;
        }
    }
    public enum GenderType
    {
        Male,
        Female,
        Other
    }

    public class Gender
    {
        public GenderType Type { get; set; }

        public Gender(GenderType type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
    public class PhoneNumber
    {
        public string Number { get; private set; }

        public PhoneNumber(string number)
        {
            if (IsValidPhoneNumber(number))
            {
                Number = number;
            }
            else
            {
                throw new ArgumentException("Invalid phone number format.");
            }
        }
        //StartsWith:
        //تُستخدم لفحص ما إذا كانت السلسلة (String) تبدأ بنص معين أو لا. هذه الوظيفة تعود بقيمة منطقية (bool) تدل على نتيجة الفحص
        public bool IsValidPhoneNumber(string number)
        {
            return (number.StartsWith("077") || number.StartsWith("078") || number.StartsWith("079")) && number.Length == 10;
        }
    }
    public class Employees
    {
        public Range AgeRange { get; private set; }
        public Gender Person1Gender { get; private set; }
        public Gender Person2Gender { get; private set; }
        public string Name { get; private set; }
        public string EMail { get; private set; }
        public int ID { get; private set; }
        public PhoneNumber Phone1 { get; private set; }
        public PhoneNumber Phone2 { get; private set; }
        public PhoneNumber Phone3 { get; private set; }

        public Employees(Range ageRange, Gender person1Gender, Gender person2Gender, string name, string eMail, int iD, PhoneNumber phone1, PhoneNumber phone2, PhoneNumber phone3)
        {
            AgeRange = ageRange;
            Person1Gender = person1Gender;
            Person2Gender = person2Gender;
            Name = name;
            EMail = eMail;
            ID = iD;
            Phone1 = phone1;
            Phone2 = phone2;
            Phone3 = phone3;
        }
    }
}
