// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


static void FizzBuzz()
{
    for (int i = 1; i < 256; i++)
    {
        string numberString = createWord(i);
        Console.WriteLine(numberString);
    }
}

FizzBuzz();

static string createWord(int i)
{
    List<string> words = new List<string>();

    if (i % 3 == 0) words.Add("Fizz");
    if (i % 5 == 0) words.Add("Buzz");
    if (i % 7 == 0) words.Add("Bang");

    if (i % 11 == 0)
    {
        words.Clear();
        words.Add("Bong");
    }

    if (i % 13 == 0)
    {
        if (words.Count > 0)
        {
            bool addedFezz = false;

            for (int k = 0; k < words.Count; k++)
            {
                if (addedFezz) break;
                char firstChar = words[k][0];
                if (firstChar == 'B')
                {
                    words.Insert(k, "Fezz");
                    addedFezz = true;
                    break;
                }
            }
            if(!addedFezz) words.Add("Fezz");
        }
        else
        {
            words.Add("Fezz");
        }
    }

    if (i % 17 == 0) words.Reverse();

    return words.Count > 0 ? String.Join("", words) : i.ToString();
    
}