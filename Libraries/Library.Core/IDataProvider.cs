namespace Library.Core
{
    public interface IDataProvider
    {
        void AddData(string data);

        string GetData();
    }
}
