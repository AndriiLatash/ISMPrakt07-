using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Date
    {
        protected int Day;
        protected int Month;
        protected int Year;
        protected int Hours;
        protected int Minutes;
      
        public Date()
        {
           
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }

        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }
        public int GetHours()
        {
            return Hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetMonth(int month)
        {
            Month = month;
        }
        public void SetDay(int day)
        {
            Day = day;
        }
        public void SetHours(int hours)
        {
            Hours = hours;
        }
        public void SetMinutes(int minutes)
        {
            Minutes = minutes;
        }
    }
}
