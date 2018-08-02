using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Pages;

namespace FactoryMethod
{
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            WriteDocument();
        }

        public abstract void WriteDocument();
       
        public List<Page> Pages
        {
            get
            {
                return _pages;
            }
        }
    }
}
