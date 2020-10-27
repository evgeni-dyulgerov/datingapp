using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;

            // if the person hadn't had his birthday this year, the person is 1 year younger a.k.a. age--
            if(dob.Date > today.AddYears(-age)) age--; 
            return age;
        }
    }
}