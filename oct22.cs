//ループ形式のコードが必要になったら、それをクエリ形式で記述できないか検討してみると良いでしょう
//クエリ構文が機能しないのであれば、メソッド呼び出し形式を試すとよいでしょう
//ほとんどの場合において、命令形式のループを記述するよりもクエリ形式の方がコードが簡潔になるでしょう

//クエリ構文とメソッド構文の2種類が存在する

using System;

class oct22
{
    static void Main(string[] args)
    {
        //クエリ構文
        var evens = from number in numbers
                    where number % 2 == 0
                    seclect number;

        //メソッドベースの構文
        var evens = numbers.Where(number => number % 2 == 0)
                           .Select(number => number);
    }
}


諸説ありますが、由来としては「計算式を書く時に同じ式を何度も書くと大変なので、対象の関数をΛ（ラムダ）と置いて記述を省略する」というところから来ています。
数学では変数をxやyと置いて計算しますが、それの関数バージョンがΛだったということになります。

つまり、「ラムダ」という記号に深い意味などはなく、単に習慣で決まっただけの名前ということです。

//使い捨ての関数　正確には匿名関数
//デリゲートとは関数を代入できる変数
//関数の引数をデリゲートにする」ことで、「関数から別の関数を呼び出す」という処理を外から切り替えることができるようになります。
//デリゲートとは、「関数を代入できる変数」みたいなものです。

public class Sample2
{
    public void Start()
    {
        _ = WaitForAsync(5, () => Console.WriteLine("Do!"));
    }
    private async Task WaitForAsync(float seconds, Action action)
    {
        await Task.Delay(TimeSpan.FromSeconds(seconds));
        action();
    }
}

//ラムダ式はメソッドをオブジェクト化する機能です

public static void Main(string[] args)
{
    var list = new List<int> {1,84,95,95,40,6};

    var resultList1 = list
        .Where(x => x % 2 == 0)
        .OrderBy(x => x)
        .Select(x => x * 3);

    Console.WriteLine("====result====");

    foreach(var x in resultList2)
    {
        Console.WriteLine(x);
    }

}

//関数をデリゲートに登録しておいて、後からデリゲート経由でその関数を呼び出す

private void Do()
{
    Console.WriteLine("DO!");
}

public void Start()
{
    Action action = Do;

    action();
    //Do関数が実行される

    action.Invoke();
}