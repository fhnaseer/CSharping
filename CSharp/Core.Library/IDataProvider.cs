namespace Core.Library
{
    public interface IDataProvider
    {
        void AddData(string data);

        string GetData();
    }
}
