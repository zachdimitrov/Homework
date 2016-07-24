namespace HTMLRenderer.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new Element(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new Element(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new Table[rows, cols];
        }
    }
}
