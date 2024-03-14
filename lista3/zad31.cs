// indeks: 347818
// Patryk Nogaś


using System;
using System.Collections.Generic;

namespace TimeNTonNamespace
{
    public sealed class TimeNTon
    {
        private static int N = 2; // maksymalna liczba instancji
        private static List<TimeNTon> instances = new List<TimeNTon>();
        private int currentIndex = 0;

        public int ReadCurrentIndex()
        {
            return this.currentIndex;
        }
        public TimeNTon()
        {
            this.currentIndex = instances.Count;
        }

        public static TimeNTon GetInstance()
        {
            if (IsWorkingHours() & instances.Count < N)
            {
                var instance = new TimeNTon();
                instances.Add(instance);
                return instance;
            }
            else
            {
                if (instances.Count > 0)
                {
                    return instances[0];
                }
                else
                {
                    return null;
                }
            }
        }

        private static bool IsWorkingHours()
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime.Hour >= 12 && currentTime.Hour <= 14 && currentTime.DayOfWeek == DayOfWeek.Thursday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
