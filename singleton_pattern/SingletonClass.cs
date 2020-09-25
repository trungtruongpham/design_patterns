using System;

namespace singleton_pattern_example
{
    public class SingletonClass
    {
        private static SingletonClass _instance = new SingletonClass();
        private static int i = 0;

        //Eager Init
        public static SingletonClass GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonClass();
            }

            i++;

            Console.WriteLine(i);

            return _instance;
        }


        //Lazy Init
        public class LazyInitializedSingleton
        {

            private static LazyInitializedSingleton instance;

            private LazyInitializedSingleton() { }

            public static LazyInitializedSingleton getInstance()
            {
                if (instance == null)
                {
                    instance = new LazyInitializedSingleton();
                }
                return instance;
            }
        }
    }
}