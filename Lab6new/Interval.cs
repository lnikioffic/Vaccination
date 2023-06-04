using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new
{
    internal class Interval
    {
        
        public Interval(DateOnly startDate, string duration ) {

            StartDate = startDate;
            var dur = 0;
            if(int.TryParse(duration, out dur))
                EndDate = StartDate.AddDays(dur);
            else
                throw new ArgumentException("Длительность должна быть числом");
        }

        public Interval(DateOnly startDate, int duration)
        {

            StartDate = startDate;
            EndDate = StartDate.AddDays(duration);

        }

        public Interval(DateOnly startDate, DateOnly endDate)
        {

            StartDate = startDate;
            EndDate = endDate;

        }

        public DateOnly StartDate { get; }

        public DateOnly EndDate { get; }

    }
}
