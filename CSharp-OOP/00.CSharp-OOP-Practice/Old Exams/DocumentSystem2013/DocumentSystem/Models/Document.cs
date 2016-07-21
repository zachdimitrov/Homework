namespace DocumentSystem.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Document : IDocument
    {
        public Document(string name)
        {
            this.Name = name;
        }

        public Document(string name, string content) : this(name)
        {
            this.Content = content;
        }

        public string Content { get; private set; }

        public string Name { get; private set; }

        public void LoadProperty(string key, string value)
        {
            throw new NotImplementedException();
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }
    }
}
