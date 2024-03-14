// indeks: 347818
// Patryk Nogaś


using System;
using TimeNTonNamespace;

public class MainClass
{
    public static void Main()
    {
        TimeNTon instance0 = TimeNTon.GetInstance();
        TimeNTon instance1 = TimeNTon.GetInstance();
        TimeNTon instance2 = TimeNTon.GetInstance();
        TimeNTon instance3 = TimeNTon.GetInstance();
        // w godzinach pracowni to powinno być 0, 1, 0, 0 == czyli mamy dwa elementy instance0 i instance1
        Console.WriteLine(instance0.ReadCurrentIndex());
        Console.WriteLine(instance1.ReadCurrentIndex());

        // a instance2-3 zwracają inne instancje, bo N=2
        Console.WriteLine(instance2.ReadCurrentIndex());
        Console.WriteLine(instance3.ReadCurrentIndex());

        // w innych godzinach może to nie działać bo zwracamy albo jakiś obiekt który istnieje albo null, a null nie ma metody ReadCurrentIndex
    }
}