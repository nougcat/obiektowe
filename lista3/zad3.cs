using System;
using System.Collections.Generic;

sealed class TimeNTon
{
    private static int N=2; // maksymalna liczba instancji
    private static List<TimeNTon> instances = new List<TimeNTon>();
    private int currentIndex = 0;
    
    public int ReadCurrentIndex(){
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
        if (currentTime.Hour >= 13 && currentTime.Hour <= 15)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class MainClass
{
    public static void Main()
    {
        TimeNTon instance1 = TimeNTon.GetInstance();
        TimeNTon instance2 = TimeNTon.GetInstance();
        TimeNTon instance3 = TimeNTon.GetInstance();
        TimeNTon instance4 = TimeNTon.GetInstance();
        TimeNTon instance5 = TimeNTon.GetInstance();
        Console.WriteLine(instance4);
    }
}