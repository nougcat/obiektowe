// indeks: 347818
// Patryk Nogaś

using System;
using System.Collections;
using System.Collections.Generic;

public class FibonacciWords : IEnumerable<string>
{
    private int _count;

    public FibonacciWords(int count)
    {
        _count = count;
    }

    public IEnumerator<string> GetEnumerator()
    {
        string when_odd_index = "a";
        string when_even_index = "b";

        yield return when_odd_index;

        if (_count >= 1)
        {
            yield return when_even_index;
        }
        else if (_count == 2)
        {
            yield return when_odd_index;
        }

        for (int i = 2; i < _count; i++)
        {
            if (i % 2 == 0)
            {
                when_even_index = when_odd_index + when_even_index;
                yield return when_even_index;
            }
            else
            {
                when_odd_index = when_even_index + when_odd_index;
                yield return when_odd_index;
            }

        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MainClass
{
    public static void Main()
    {
        FibonacciWords sf = new FibonacciWords(6);
        foreach (string s in sf)
            Console.WriteLine(s);
        FibonacciWords sf_2 = new FibonacciWords(6);
        foreach (string s1 in sf_2)
            foreach (string s2 in sf_2)
                System.Console.WriteLine(s1, s2);

    }
}