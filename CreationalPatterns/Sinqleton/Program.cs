using Singleton.Lab_1;
using Singleton.Lab_2;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            var singletonPattern =SingletonPattern.CreateSingletonObject();
            singletonPattern.CreateLog();
            #endregion
            Console.ReadKey();

            #region Lab_2
            Console.WriteLine($"Sonuç:{SingletonClass.SingletonObject.Toplam(4, 5)}");
            #endregion
            Console.ReadKey();

        }

    }
}
