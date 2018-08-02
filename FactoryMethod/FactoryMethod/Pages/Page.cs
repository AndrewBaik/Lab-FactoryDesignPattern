using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Pages
{
    public abstract class Page
    {
        public Page()
        {
            Prepare();
            Write();
            Refactor();
        }

        public void Prepare()
        {
            Console.WriteLine("I'm preparing my page.");
        }

        public void Write()
        {
            Console.WriteLine("I'm writing my page");
        }

        public void Refactor()
        {
            Console.WriteLine("I'm refactoring my page");
        }
    }
}
    