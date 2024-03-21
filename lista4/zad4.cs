// indeks: 347818
// Patryk Nogaś

using System;
using System.Collections;
using System.Collections.Generic;

public class NieTerminale
{
    private string[] nieterminale_arr;
    public NieTerminale(string[] nieterminale_input)
    {
        this.nieterminale_arr = nieterminale_input;
    }
    public string[] GetNonTerminals
    {
        get { return this.nieterminale_arr; }
    }
}
public class Terminale
{
    private string[] terminale_arr;
    public Terminale(string[] terminale_input)
    {
        this.terminale_arr = terminale_input;
    }
    public string[] GetTerminals
    {
        get { return this.terminale_arr; }
    }
}

public class Produkcja
{
    private List<List<string>> produkcja_list;
    public Produkcja(List<List<string>> produkcja_input)
    {
        this.produkcja_list = produkcja_input;
    }
    public List<List<string>> GetProductions
    {
        get { return this.produkcja_list; }
    }
}

public class MainClass
{
    static string symbol_startowy = "S";

    public static void Main()
    {
        // nieterminale
        string[] inicjowane_nieterminale = new string[] { "S", "Z", "C", "X" };
        NieTerminale nieterminale = new NieTerminale(inicjowane_nieterminale);
        // terminale
        string[] inicjowane_terminale = new string[] { "a", "b", "c", "d", "x", "y", "z" };
        Terminale terminale = new Terminale(inicjowane_terminale);

        // produkcja
        List<List<string>> inicjowana_produkcja = new List<List<string>>();
        for (int i = 0; i < inicjowane_nieterminale.Length; i++)
            inicjowana_produkcja.Add(new List<string>());
        inicjowana_produkcja[0].Add("aZ");
        inicjowana_produkcja[0].Add("xS");
        inicjowana_produkcja[0].Add("bC");
        //inicjowana_produkcja[1].Add("bXXX");
        inicjowana_produkcja[1].Add("y");
        inicjowana_produkcja[2].Add("cX");
        inicjowana_produkcja[2].Add("z");
        inicjowana_produkcja[3].Add("dC");

        Produkcja produkcja = new Produkcja(inicjowana_produkcja);

        // wypisywanie terminali etc.
        Console.WriteLine("Nieterminale: ");
        for (int i = 0; i < nieterminale.GetNonTerminals.Length; i++)
        {
            Console.Write($"{nieterminale.GetNonTerminals[i]}, ");
        }
        Console.WriteLine("\nTerminale: ");
        for (int i = 0; i < terminale.GetTerminals.Length; i++)
        {
            Console.Write($"{terminale.GetTerminals[i]}, ");
        }
        Console.WriteLine("\nProdukcje: ");
        for (int i = 0; i < nieterminale.GetNonTerminals.Length; i++)
            foreach (string produkt in produkcja.GetProductions[i])
                Console.WriteLine($"{nieterminale.GetNonTerminals[i]} -> {produkt}");

        // generowanie wyrazu
        Console.WriteLine("Generowanie rand wyrazu");
        generuj(inicjowane_nieterminale, inicjowane_terminale, inicjowana_produkcja, symbol_startowy, 10);
    }
    public static string generuj(string[] inicjowane_nieterminale, string[] inicjowane_terminale, List<List<string>> inicjowana_produkcja, string startingSymbol, int maximumWordLength = 10)
    {
        // nieterminale
        NieTerminale nonTerminals = new NieTerminale(inicjowane_nieterminale);
        // terminale
        Terminale terminals = new Terminale(inicjowane_terminale);
        // produkcja
        Produkcja production = new Produkcja(inicjowana_produkcja);
        // wyraz startowy
        string word = startingSymbol;


        Random rand = new Random();
        int i = 0;

        while (i < maximumWordLength)
        {
            string stare_slowo = word;
            for (int j = 0; j < word.Length; j++)
            {
                if (Array.IndexOf(nonTerminals.GetNonTerminals, word[j].ToString()) != -1)
                {
                    int nonTerminalIndex = Array.IndexOf(nonTerminals.GetNonTerminals, word[j].ToString());
                    int los = rand.Next(0, production.GetProductions[nonTerminalIndex].Count);
                    string nowa_czesc_slowa = production.GetProductions[nonTerminalIndex][los];
                    word = word.Replace(word[j].ToString(), nowa_czesc_slowa);
                    j += production.GetProductions[nonTerminalIndex][los].Length-1; // skipujemy następny element bo to jest albo terminal albo nieterminal który już został zastąpiony
                }
                Console.Write(word);
            }
            i++;
            if (stare_slowo == word)
            {
                break;
            }
            else
            {
                Console.Write("->");
            }
        }
        Console.WriteLine();
        return word;
    }

}