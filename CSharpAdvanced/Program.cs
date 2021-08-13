using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            /*object obj = "Uriel";
            //obj.GetHashCode();

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo?.Invoke(null, null);

            dynamic excelObject = "Uriel";
            excelObject.Optimize();*/


            dynamic name = "Uriel";
            //name = 10;
            //name++; throws exception when applied on string

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            int i = 5;
            dynamic d = i;
            long l = d;
        }
    }
}
