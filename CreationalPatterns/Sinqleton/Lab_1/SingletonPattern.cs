using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Lab_1
{
   public class SingletonPattern
    {
        private static SingletonPattern _singletonPattern;
        private SingletonPattern() { }
        public static SingletonPattern CreateSingletonObject()
        {
            if (_singletonPattern == null)
            {
                _singletonPattern = new SingletonPattern();
            }
            return _singletonPattern;
        }
        public void CreateLog() => Console.WriteLine("A log was created");
    }
}
