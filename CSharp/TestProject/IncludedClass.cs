using System.Diagnostics.CodeAnalysis;

namespace TestProject;

public class IncludedClass
{
    public class SubIncludedClass
    {
        public string? IncludedProperty { get; set; }

        [ExcludeFromCodeCoverage]
        public string? ExcludedProperty
        {
            get { return IncludedProperty; }
            set { IncludedProperty = value; }
        }

        public string? MixedProperty
        {
            [ExcludeFromCodeCoverage]
            get { return IncludedProperty; }
            set { IncludedProperty = value; }
        }

        public void IncludedMethod(string? text)
        {
            IncludedProperty = text;
        }

        [ExcludeFromCodeCoverage]
        public void ExcludedMethod(string? text)
        {
            IncludedProperty = text;
        }
    }

    [ExcludeFromCodeCoverage]
    public class SubExcludedClass
    {
        public string? IncludedProperty
        {
            get { return ExcludedProperty; }
            set { ExcludedProperty = value; }
        }

        [ExcludeFromCodeCoverage]
        public string? ExcludedProperty { get; set; }
    }

    public string? IncludedProperty
    {
        get { return MixedProperty; }
        set { MixedProperty = value; }
    }

    [ExcludeFromCodeCoverage]
    public string? ExcludedProperty
    {
        get { return MixedProperty; }
        set { MixedProperty = value; }
    }

    public string? MixedProperty
    {
        [ExcludeFromCodeCoverage]
        get; set;
    }

    public void IncludedMethod(string? text)
    {
        MixedProperty = text;
    }

    [ExcludeFromCodeCoverage]
    public void ExcludedMethod(string? text)
    {
        MixedProperty = text;
    }

    private EventHandler? _event;

    public event EventHandler IncludedEvent
    {
        add { _event += value; }
        remove { _event -= value; }
    }

    [ExcludeFromCodeCoverage]
    public event EventHandler ExcludedEvent
    {
        add { _event += value; }
        remove { _event -= value; }
    }

    public event EventHandler MixedEvent
    {
        add { _event += value; }
        [ExcludeFromCodeCoverage]
        remove { _event -= value; }
    }
}
