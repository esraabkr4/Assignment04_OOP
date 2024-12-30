using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_OOP
{
    internal class Duration
    {
		private int hours;

		public int Hours
        {
			get { return hours; }
			set { hours = value<=12?value:12; }
		}

		private int minutes;

		public int Minutes
        {
			get { return minutes; }
			set { minutes = value<=60?value:60; }
		}

		private int seconds;

		public int Seconds
        {
			get { return seconds; }
			set { seconds = value<=60?value:60; }
		}
        public Duration()
        {
            
        }
        public Duration(int hours,int minutes,int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        
        public Duration(int time)
        {
            var timeSpan = TimeSpan.FromSeconds(time);
            this.hours = timeSpan.Hours;
            this.minutes = timeSpan.Minutes;
            this.seconds = timeSpan.Seconds;
        }
        
        public override string ToString()
        {
            return $"Hours: {hours}, Minutes :{minutes}, Seconds :{seconds}";
        }

		public override bool Equals(object? obj)
		{
			Duration dur = obj as Duration;
			return base.Equals(dur.Hours) && base.Equals(dur.minutes) && base.Equals(dur.seconds);
		}
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Duration operator +(Duration D1, Duration D2)
        {
            if (D1!=null && D2!=null)
            {
                return new Duration(D1.hours+D2.Hours,D1.minutes+D2.minutes,D1.seconds+D2.seconds);
            }
            return new Duration();
        }
        
        public static Duration operator +(Duration D1, int time)
        {
            Duration D2=new Duration(time);
            if (D1 != null && D2 != null)
            {
                return new Duration(D1.hours + D2.Hours, D1.minutes + D2.minutes, D1.seconds + D2.seconds);
            }
            return new Duration();

        }
        
        public static Duration operator +(int time, Duration D1)
        {
            Duration D2 = new Duration(time);
            if (D1 != null && D2 != null)
            {
                return new Duration(D1.hours + D2.Hours, D1.minutes + D2.minutes, D1.seconds + D2.seconds);
            }
            return new Duration();
        }
       
        public static Duration operator ++(Duration dur)
        {
            return new Duration(dur.hours,++dur.minutes,dur.seconds);
        }
       
        public static Duration operator --(Duration dur)
        {
            return new Duration(dur.hours, --dur.minutes, dur.seconds);
        }
        
        public static Duration operator -(Duration D1, Duration D2)
        {
            if (D1 != null && D2 != null)
            {
                return new Duration(D1.hours - D2.Hours, D1.minutes - D2.minutes, D1.seconds - D2.seconds);
            }
            return new Duration();
        }
        
        public static bool operator >(Duration D1, Duration D2)
        {
            if (D1 !=null && D2 !=null)
            {
                if (D1.hours > D2.hours)
                    return true;
                else if (D1.hours < D2.hours)
                    return false;
                else
                {
                    if (D1.minutes > D2.minutes)
                        return true;
                    else if (D1.minutes < D2.minutes)
                        return false;
                    else
                    {
                        if (D1.seconds > D2.seconds)
                            return true;
                        else
                            return false;
                    }
                }
                
            }
            return false;
        }

        public static bool operator <(Duration D1, Duration D2)
        {
            if (D1 != null && D2 != null)
            {
                if (D1.hours < D2.hours)
                    return true;
                else if (D1.hours > D2.hours)
                    return false;
                else
                {
                    if (D1.minutes < D2.minutes)
                        return true;
                    else if (D1.minutes > D2.minutes)
                        return false;
                    else
                    {
                        if (D1.seconds < D2.seconds)
                            return true;
                        else
                            return false;
                    }
                }

            }
            return false;
        }
       
        public static bool operator <=(Duration D1, Duration D2)
        {
            if (D1 != null && D2 != null)
            {
                if (D1.hours <= D2.hours)
                    return true;
                else 
                    return false;
            }
            return false;
        }
        
        public static bool operator >=(Duration D1, Duration D2)
        {
            if (D1 != null && D2 != null)
            {
                if (D1.hours >= D2.hours)
                    return true;
                else
                    return false;
            }
            return false;
        }
       
        public static explicit operator DateTime(Duration duration)
        {
            DateTime currentDate = DateTime.Now; 
            return currentDate.AddHours(duration.Hours)
                    .AddMinutes(duration.Minutes)
                    .AddSeconds(duration.Seconds);

        }

    }
}
