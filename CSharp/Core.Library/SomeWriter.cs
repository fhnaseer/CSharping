namespace Core.Library
{
    public class SomeWriter
    {
        private readonly IDataProvider _dataProvider;

        public SomeWriter(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void AddLog(string text)
        {
            _dataProvider.AddData(text);
        }

        public string GetLog()
        {
            return _dataProvider.GetData();
        }
    }
}
