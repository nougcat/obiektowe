using System;
using System.Collections.Generic;

public class MyDictionary<K, V>
{
    private Dictionary<K, V> dictionary;

    public MyDictionary()
    {
        dictionary = new Dictionary<K, V>();
    }

    // Dodawanie elementu do słownika
    public void AddElement(K key, V value)
    {
        dictionary[key] = value;
    }

    // Wyszukiwanie elementu po kluczu
    public V FindElement(K key)
    {
        V value;
        if (dictionary.TryGetValue(key, out value))
        {
            return value;
        }
        else
        {
            throw new KeyNotFoundException("Key not found");
        }
    }

    // Usuwanie elementu po kluczu
    public void RemoveElement(K key)
    {
        if (!dictionary.Remove(key))
        {
            throw new KeyNotFoundException("Key not found");
        }
    }

    
}

public class MainClass
{
    public static void Main()
    {
        MyDictionary<string, int> dictionary = new MyDictionary<string, int>();

        dictionary.AddElement("one", 1);
        dictionary.AddElement("two", 2);
        dictionary.AddElement("three", 3);

        Console.WriteLine(dictionary.FindElement("one"));
        Console.WriteLine(dictionary.FindElement("two"));
        Console.WriteLine(dictionary.FindElement("three"));

        dictionary.RemoveElement("two");

        try
        {
            Console.WriteLine(dictionary.FindElement("two"));
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

