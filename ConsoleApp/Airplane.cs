using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public Airplane()
        {
        
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        public void SetStartCity(string startCity)
        {
            StartCity = startCity;
        }
        public void SetFinishCity(string finishCity)
        {
            FinishCity = finishCity;
        }
        public void SetStartDate(Date startDate)
        {
            StartDate = startDate;
        }
        public void SetFinishDate(Date finishDate)
        {
            FinishDate = finishDate ;
        }
        public bool IsArrivingToday(Date startDate, Date finishDate)
        {
            if(startDate == finishDate)
            {
                return true;
            }
            return false;
        }
       

    }
}
