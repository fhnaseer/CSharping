using System;
using System.Diagnostics.CodeAnalysis;

namespace UnitTests.Core
{
    public class IncludedClass
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

        [ExcludeFromCodeCoverage]
        public class SubExcludedClass
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

        private EventHandler _event;

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
}
