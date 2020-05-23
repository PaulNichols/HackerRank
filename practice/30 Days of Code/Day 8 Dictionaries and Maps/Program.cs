using System;
using System.Collections.Generic;

internal class Solution
{
    private static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        var phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] keyValue = Console.ReadLine().Split(' ');
            phoneBook.Add(keyValue[0], keyValue[1]);
        }

        var queries = new List<string>();
        string query;

        do
        {
            query = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(query))
            {
                queries.Add(query);
            }
        } while (!string.IsNullOrWhiteSpace(query));

        for (int i = 0; i < queries.Count; i++)
        {
            if (phoneBook.ContainsKey(queries[i]))
            {
                Console.WriteLine($"{queries[i]}={phoneBook[queries[i]]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}