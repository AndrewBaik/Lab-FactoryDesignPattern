using FactoryMethod.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Resume : Document
    {
        public override void WriteDocument()
        {
            Pages.Add(new Summary());
            Console.WriteLine("I have added Summary page to my Resume");
            Console.WriteLine();

            Pages.Add(new Education());
            Console.WriteLine("I have added Education page to my Resume");
            Console.WriteLine();

            Pages.Add(new Skills());
            Console.WriteLine("I have added Skill page to my Resume");
            Console.WriteLine();

            Pages.Add(new Experiences());
            Console.WriteLine("I have added Experience page to my Resume");
            Console.WriteLine();
        }
    }
}
