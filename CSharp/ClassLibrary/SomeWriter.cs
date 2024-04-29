namespace ClassLibrary;

public class SomeWriter(IDataProvider dataProvider)
{
    private readonly IDataProvider _dataProvider = dataProvider;

    public void AddLog(string text) => _dataProvider.AddData(text);

    public string GetLog() => _dataProvider.GetData();
}