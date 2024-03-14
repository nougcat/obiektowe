using System;
using mojaLista;

public class MainClasss
{
    public static void Main()
    {
        Lista<int> lista = new Lista<int>();

        lista.PushFront(1);
        lista.PushFront(2);
        lista.PushFront(3);
        lista.PushFront(4);
        lista.PushFront(5);

        while (!lista.IsEmpty())
        {
            Console.WriteLine(lista.PopFront());
        }

        lista.PushBack(10);
        lista.PushBack(9);
        lista.PushBack(8);
        lista.PushBack(7);
        lista.PushBack(6);
        while (!lista.IsEmpty())
        {
            Console.WriteLine(lista.PopFront());
        }
        Console.WriteLine(lista.IsEmpty());

        Console.WriteLine(lista.PopFront());

        Console.WriteLine(lista.PopBack());
    }
}