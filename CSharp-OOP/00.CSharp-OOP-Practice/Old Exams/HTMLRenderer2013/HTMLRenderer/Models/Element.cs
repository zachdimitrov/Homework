using HTMLRenderer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer.Models
{
    public class Element : BaseElement, IElement, IBaseElement
    {
        public Element(string name, string content = null) : base(name)
        {
            this.childElements = new List<IElement>();
            this.TextContent = content;
        }

        private ICollection<IElement> childElements;

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public string TextContent { get; set; }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>{1}{2}</{0}>", this.Name, EncodeContent(this.TextContent), string.Join("", this.ChildElements));
        }

        private string EncodeContent(string textContent)
        {
            if (!string.IsNullOrEmpty(textContent))
            {
                textContent = textContent
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;")
                    .Replace("&", "&amp;");
            }
            return textContent;
        }
    }
}
