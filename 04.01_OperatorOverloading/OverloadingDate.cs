namespace Training._04._01_OperatorOverloading
{
    class OverloadingDate
    {
        public int Year { get; private set; }

        public int Month { get; private set; }

        public int Day { get; private set; }

        public OverloadingDate(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public override string ToString()
        {
            return string.Format("{0:D2}.{1:D2}.{2:D4}", this.Day, this.Month, this.Year);
        }

        public OverloadingDate AddDays(int dayCount)
        {
            this.Day += dayCount;
            return this;
        }

        public static OverloadingDate operator +(OverloadingDate date, int dayCount)
        {
            //date.Day += dayCount;
            //return date;
            return new OverloadingDate(date.Day + dayCount, date.Month, date.Year);
        }

        public static OverloadingDate operator ++(OverloadingDate date)
        {
            //date.Day++;
            //return date;
            return new OverloadingDate(date.Day + 1, date.Month, date.Year);
        }

        public static bool operator ==(OverloadingDate date1, OverloadingDate date2)
        {
            if(ReferenceEquals(date1, date2))
            {
                return true;
            }

            if(ReferenceEquals(date1, null) || ReferenceEquals(date2, null))
            {
                return false;
            }

            return date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year;
        }

        public static bool operator !=(OverloadingDate date1, OverloadingDate date2)
        {
            return !(date1 == date2);
        }

        /*public static explicit operator string (OverloadingDate date)
        {
            return date.ToString();
        }*/

        public static implicit operator string(OverloadingDate date)
        {
            return date.ToString();
        }
    }

}
