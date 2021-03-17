using System.Diagnostics.CodeAnalysis;

namespace Core.UnitTests
{
    [ExcludeFromCodeCoverage]
    public class ExcludedClass
    {
        public class SubIncludedClass
        {
            private string _includedField;

            public string IncludedProperty
            {
                get { return _includedField; }
                set { _includedField = value; }
            }

            [ExcludeFromCodeCoverage]
            public string ExcludedProperty
            {
                get { return _includedField; }
                set { _includedField = value; }
            }

            public string MixedProperty
            {
                [ExcludeFromCodeCoverage]
                get { return _includedField; }
                set { _includedField = value; }
            }

            public void IncludedMethod(string text)
            {
                _includedField = text;
            }

            [ExcludeFromCodeCoverage]
            public void ExcludedMethod(string text)
            {
                _includedField = text;
            }
        }

        private string _includedField;

        public string IncludedProperty
        {
            get { return _includedField; }
            set { _includedField = value; }
        }

        [ExcludeFromCodeCoverage]
        public string ExcludedProperty
        {
            get { return _includedField; }
            set { _includedField = value; }
        }

        public string MixedProperty
        {
            [ExcludeFromCodeCoverage]
            get { return _includedField; }
            set { _includedField = value; }
        }

        public void IncludedMethod(string text)
        {
            _includedField = text;
        }

        [ExcludeFromCodeCoverage]
        public void ExcludedMethod(string text)
        {
            _includedField = text;
        }
    }
}
