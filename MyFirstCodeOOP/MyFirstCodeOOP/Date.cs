using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class Date
    {
        #region Properties
        public int _year;
        public int _month;
        public int _day;
        #endregion

        #region Constructor
        public Date(int year, int month, int day)
        {
            this._year = ValidateYear(year);
            this._month = ValidateMonth(month);
            this._day = ValidateDay(day, month);
        }

        #endregion


        #region Metodos
        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }

        private  int ValidateDay(int day, int month)
        {
            if (month == 2)
            {
                if (day >= 1 && day <= 28)
                {
                    return day;
                }
                else
                {
                    throw new DayExeption("The day is invalid!!");
                }
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8)
            {
                if (day >=1 && day <=31)
                {
                    return day;
                }
            }
            else
            {
                if (day >= 1 && day <= 30)
                {
                    return day;
                }
            }

            throw new DayExeption("The day is invalid!!");


        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month<= 12) 
            {
                return month;
            }

            throw new MonthExeption("The month is invalid!!");


        }

        private int ValidateYear(int year)
        {
            if (year > 1900)
            {
                return year;
            }
            throw new YearException("Year is invalid!!");
        }

        #endregion
    }
}
