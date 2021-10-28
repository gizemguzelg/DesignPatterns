using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Lab_2
{
   public class SingletonClass
    {
        private SingletonClass() { }
        private static SingletonClass _singleObject;
        public static SingletonClass SingletonObject
        {
            get
            {
                if(_singleObject==null)
                {
                    _singleObject = new SingletonClass();
                }
                return _singleObject;
            }
        }
        public int Toplam(int s1, int s2) => s1 + s2;
    }
}
