using HTMLRenderer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer.Models
{
    public abstract class BaseElement : IBaseElement
    {
        public BaseElement(string name = null)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void Render(StringBuilder output);

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Render(sb);
            return sb.ToString();
        }
    }
}
