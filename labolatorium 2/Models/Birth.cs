using System;

namespace labolatorium_2.Models
{
    public class Birth
    {
        public string imie { get; set; }
        public DateTime data { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(imie) && data < DateTime.Now;
        }
        public int howold()
        {
            int age = DateTime.Now.Year - data.Year;
            if(DateTime.Now.DayOfYear < data.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}
