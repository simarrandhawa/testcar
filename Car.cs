using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cars
{
    public class Car
    {
        private string _model;
        private int _year;

        public string Model
        {
            get { return _model; }
            set
            {
                CheckModel(value); _model = value; }
        }

        public string Brand { get; set; 


        public int Year
        {
            get { return _year; }
            set
            {
                CheckYear(value);
                _year = value;
            }
        }

        private static void CheckYear(int year)
        {
            if ((year < 0 )||(year > 2014))
            {
                throw new ArgumentOutOfRangeException("year", year, "Year must be positive and less than 2015");
            }
        }

        private static void CheckModel(string model)
        {
            if (String.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model is null or empty");
            }
        }
    }
}
