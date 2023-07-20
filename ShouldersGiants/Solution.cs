using System;
using System.Collections.Generic;


namespace ShouldersGiants
{
    class Solution
    {
        static int DFS(int person, Dictionary<int, List<int>> graph, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(person))
                return memo[person];

            int maxChainLength = 1;

            if (graph.ContainsKey(person))
            {
                foreach (int node in graph[person])
                {
                    int chainLength = DFS(node, graph, memo);
                    maxChainLength = Math.Max(maxChainLength, 1 + chainLength);
                }
            }

            memo[person] = maxChainLength;
            return maxChainLength;
        }
        static int FindLongestSuccession(List<Tuple<int, int>> influences)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            foreach (var influence in influences)
            {
                int influencer = influence.Item1;
                int influenced = influence.Item2;
                if (!graph.ContainsKey(influencer))
                    graph[influencer] = new List<int>();
                graph[influencer].Add(influenced);
            }

            Dictionary<int, int> memo = new Dictionary<int, int>();
            int maxChainLength = 0;
            foreach (int person in graph.Keys)
            {
                int chainLength = DFS(person, graph, memo);
                maxChainLength = Math.Max(maxChainLength, chainLength);
            }

            return maxChainLength;
        }

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter the number of Relationships:");
                    int n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Number of relationships must be valid.");
                        break;
                    }

                    List<Tuple<int, int>> influences = new List<Tuple<int, int>>();
                    Console.WriteLine("Enter the Influencer and Influenced for each relationship respectively in each new line:");
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Relationship " + (i + 1) + ":");
                        Console.WriteLine("Person X (Influencer):");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Person Y (Influenced): ");
                        int y = int.Parse(Console.ReadLine());

                        if ((x <= 0 || x >= 12) || (y <= 0 || y >= 12))
                        {
                            Console.WriteLine("Influencer (X) and Influenced (Y)  values should be between 1 and 11.");
                            break;
                        }

                        influences.Add(new Tuple<int, int>(x, y));

                    }
                    int longestSuccession = FindLongestSuccession(influences);
                    Console.WriteLine("Longest Succession of Influences: " + longestSuccession);
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
