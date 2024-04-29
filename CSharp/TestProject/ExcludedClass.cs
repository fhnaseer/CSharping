using System.Diagnostics.CodeAnalysis;

namespace TestProject;

[ExcludeFromCodeCoverage]
public class ExcludedClass
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

        public void IncludedMethod(string text)
        {
            IncludedProperty = text;
        }

        [ExcludeFromCodeCoverage]
        public void ExcludedMethod(string text)
        {
            IncludedProperty = text;
        }
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
}
