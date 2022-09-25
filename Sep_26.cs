namespace Program
{
    internal class Counter
    {
        private static int count = 0;
        private int value = 0;

        internal static void Call()
        {
            count++;
        }

        internal static int GetCount()
        {
            return count;
        }
    }
}


using System;

namespace Project1
{
	class Test1
	{
		static void Main()
		{
			Class1.Print1(); //123

			Class1 c1 = new Class1();
			c1.Print2(); //456
		}
	}
	public class Class1
	{
		public static void Print1()
		{
			Console.WriteLine("123");
		}
		public void Print2()
		{
			Console.WriteLine("456");
		}
	}
}

メソッドの前にstatic修飾子をつけます。
クラスをインスタンス化せずに静的メソッドを使用できます。
クラスメソッドや静的メソッドとも呼ばれます。
クラス自体はインスタンス化できます。
staticは、「静的」という意味です。



using System;

namespace Project1
{
	class Test1
	{
		static void Main()
		{
			Console.WriteLine(Class1.CNT);//123
			Class1.Print1(); //456
		}
	}
	public static class Class1
	{
		public static int CNT = 123;
		public static void Print1()
		{
			Console.WriteLine("456");
		}
	}
}

13行目は、クラスの前にstaticがついています。静的クラスでインスタンス化できません。
15行目は、静的な変数です。staticを削除するとエラーになります。
16行目は、静的メソッドです。staticを削除するとエラーになります。
9行目は、静的な変数を参照しています。
10行目は、静的メソッドを実行しています。



静的クラスメンバーは常にインスタンスが１つのため、たとえば、

共通のメソッドを作って、色々なところから呼び出す
共通のフィールドを定義して、クラス固有のデータとして使う
インスタンスで作ったクラス間の共有データとして使う


class Sample
{
    // 静的フィールド X
    static public int X;

    // 静的メソッド
    static public void Method_static()
    {
        // 静的メソッドからは静的フィールドしか使えない
        System.Console.WriteLine($"[Method_static] Sample.X = {Sample.X}");
    }

    // 普通のフィールド Y
    public int Y;

    // 普通のメソッド
    public void Method_dynamic()
    {
        // 静的フィールドの値を表示
        System.Console.WriteLine($"[Method_dynamic] Sample.X = {Sample.X}");
        // 静的フィールドの値を更新
        Sample.X += 10;
        // それぞれのインスタンスのフィールドの値を表示
        System.Console.WriteLine($"[Method_dynamic] this.Y = {this.Y}");
    }
}

class Program
{
    public static void Main()
    {
        // 静的クラスメンバーへのアクセス
        Sample.X = 100;
        Sample.Method_static();

        // 普通のクラスはインスタンスを作成して使う
        Sample a = new Sample() { Y = 200 };
        a.Method_dynamic();

        Sample b = new Sample() { Y = 300 };
        b.Method_dynamic();
    }
}