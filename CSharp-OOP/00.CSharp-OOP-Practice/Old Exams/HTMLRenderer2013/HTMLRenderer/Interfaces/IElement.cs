namespace HTMLRenderer.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IElement : IBaseElement
    {
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
    }
}