using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace AthleticumContract
{
    public class Contract1 : Framework.SmartContract
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World");
        }
    }
}
