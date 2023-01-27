using System;
namespace Inlämningsuppgifter_5_4
{
    class program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Adam", "Leon", "Alem", "Tim", "Ameen" };
            Array.Sort(namn);
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}