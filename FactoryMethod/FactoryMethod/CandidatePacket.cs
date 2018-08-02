using FactoryMethod.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class CandidatePacket : Document
    {
        public override void WriteDocument()
        {
            Pages.Add(new CoverLetter());
            Console.WriteLine("I have added Cover Letter page to my Candidate Packet");
            Console.WriteLine();

            Pages.Add(new JobDescription());
            Console.WriteLine("I have added Job Description page to my Candidate Packet");
            Console.WriteLine();

            Pages.Add(new Portfolio());
            Console.WriteLine("I have added Portfolio page to my Candidate Packet");
            Console.WriteLine();

            Pages.Add(new Skills());
            Console.WriteLine("I have added skill page to my Candidate Packet");
            Console.WriteLine();

            Pages.Add(new Education());
            Console.WriteLine("I have added Education page to my Candidate Packet");
            Console.WriteLine();

            Pages.Add(new Experiences());
            Console.WriteLine("I have added Experience page to my Candidate Packet");
            Console.WriteLine();
        }
    }
}
