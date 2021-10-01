using System;

namespace DotNetLab1
{
    //public abstract class Employee
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Sau DateTimeOffset pt reprezentare timezone-uri
        /// </summary>
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //private DateTime _EndDate { get; set; }
        //public DateTime EndDate
        //{
        //    get
        //    {
        //        return _EndDate;
        //    }
        //    set
        //    {
        //        if (value < StartDate)
        //        {
        //            throw new Exception();
        //        }
        //        _EndDate = value;
        //    }
        //}

        public decimal Salary { get; set; }

        public string GetFullName => $"{FirstName} {LastName}";
        public bool IsActive => (EndDate > DateTime.Now) && (DateTime.Now > StartDate);

        /// <summary>
        /// Am ales virtual pentru a putea specifica valoare default in clasa de baza si
        /// la nevoie pentru a putea inlocui formula de salut intr-o clasa ce extinde, mosteneste
        /// clasa base pentru ca formula de salut sa fie mai specifica, mai precisa.
        /// Se putea si abstract in employee dar nu mai beneficiam de posibiltiatea de
        /// a specifica valoare default => nu mai puteam instantia Employee.
        /// </summary>
        public virtual string Salutation => "Hello employee!";
        //public abstract string Salutation { get; }
    }
}