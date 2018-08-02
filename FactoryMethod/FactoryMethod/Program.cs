using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume();
            Console.WriteLine("I have my Resume!!");

            Console.WriteLine();
            Console.WriteLine();

            CandidatePacket cp = new CandidatePacket();
            Console.WriteLine("I have my Candidate Packet!!");
            Console.WriteLine();

        }
    }
}
