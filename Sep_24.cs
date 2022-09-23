using System;
using System.Collections.Generic;

namespace sample
{
    class Program : ICollect
    {
        static void Main(string[] args)
        {
            /*
            object o = Factory.GetValue();
            int i = 0 as int

            この方法ではasは使用できない
            そのため、null許容型に変更すればいい

            object o = Factory.GetValue();
            var i = o as int?;

            if(i != null)
            {
              Console.WriteLine(i.Value);
            }

            */


            object o = 5;

            int? intValue = o as int?;



        }
    }

    internal interface ICollect
    {
        //List<string> list = new List<string>();
        //list は　インターフェース内に書くことができない
        
        /*
         * 
         * メソッドを定義 internalなので　同じプロジェクトないからアクセスすることができる
        Interfaces cannot contain fields
        An interface can contain methods and properties but not fields.
        */

    }
}
