using System;
using FakeCoreCommon;

namespace FakeCoreObjects
{
    public static class SomeClass
    {
        public static void SomeMethod()
        {
            Console.WriteLine("SomeMethod");
            SomeCommonClass.SomeCommonMethod();
        }
    }
}
