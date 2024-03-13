using System;
using zad3;

public class MainClass
{
    public static void Main()
    {
        TimeNTon instance1 = TimeNTon.GetInstance();
        TimeNTon instance2 = TimeNTon.GetInstance();
        TimeNTon instance3 = TimeNTon.GetInstance();
        zad3.TimeNTon instance4 = TimeNTon.GetInstance();
    }
}