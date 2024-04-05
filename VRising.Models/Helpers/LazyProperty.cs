using System;

namespace VRising.Models.Helpers
{
    public class LazyProperty<T>
    {
        private T _value;
        public bool Initialized { get; private set; }

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                Initialized = true;
            }
        }
    }

    public class LazyProperty2<T>
    {
        private readonly Func<T> _factory;
        private bool _isInitialized;
        private T _value;

        public LazyProperty2(Func<T> factory)
        {
            _factory = factory;
        }

        public T Value
        {
            get
            {
                if (_isInitialized)
                {
                    return _value;
                }

                _value = _factory();
                _isInitialized = true;
                return _value;
            }
        }
    }
}