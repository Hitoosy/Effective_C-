using System;



/*constよりもreadonlyを使用すること
 constの使用タイミング
属性の引数　switch caseのラベル　enumの定義　リリースをまたいでも不変な値

 readonlyの使用タイミング
constの条件に該当しないものの時に使用する

　なるべく　readonlyを使用するべき
*/

namespace September
{
    enum HumanType
    {
        brave,
        cowardice
    }

    public class Sep_23
    {
        static void Main(string[] args)
        {
            HumanType type;

            type = HumanType.brave;

            type = HumanType.cowardice;

            //type = HumanType.usually; ← これはエラーになる
        }
    }


    public class UseFulValue
    {
        public static readonly int StartValue = 5;
        public const int EndValue = 10;

        for(int i = UseFulValue.StartValue; i < UseFulValue.EndValue; i++)
            {
                Console.WriteLine("値は{0}",i);
            }
    }


   public class UseFulValue
   {  
      public static readonly int StartValue = 105;
      public const int EndValue = 120;

        for(int i = UseFulValue.StartValue; i<UseFulValue.EndValue; i++)
            {
                Console.WriteLine("値は{0}",i);
            }
   }

   //結果的には105 10　が出力される

}
