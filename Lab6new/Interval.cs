using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab6new
{
    internal class Interval
    {

        public Interval(DateOnly startDate, string duration)
        {

            StartDate = startDate;
            var dur = 0;
            if (int.TryParse(duration, out dur))
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

        public Interval(string startDate, string endDate)
        {

            DateOnly date;
            if (DateOnly.TryParseExact(startDate, "dd'.'MM'.'yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None,out date))
            {
                StartDate = date;
                if (DateOnly.TryParseExact(endDate, "dd'.'MM'.'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    EndDate = date;
                else
                    throw new ArgumentException("Неверный формат конечной даты");
            }
            else
            {
                throw new ArgumentException("Неверный формат начальной даты");
            }
        }

        public DateOnly StartDate { get; }

        public DateOnly EndDate { get; }

    }
}
