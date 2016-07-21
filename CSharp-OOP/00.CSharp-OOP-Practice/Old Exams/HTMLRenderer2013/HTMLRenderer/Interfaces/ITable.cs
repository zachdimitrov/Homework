namespace HTMLRenderer.Interfaces
{
    public interface ITable : IBaseElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }
}