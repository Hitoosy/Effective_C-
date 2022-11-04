//入力された数値とその値を反転させた値が等しいかどうが調べるプログラム
using System;
using System.Linq;

class program
{
    public static void Main()
    {
        
        //remainder: 余り  temp:  
        int num = 0;
        int temp = 0;
        int remainder = 0;
        int reverse = 0;

        Console.WriteLine("Enter an integer \n");
        //入力された数値をnum
        num = int.Parse(Console.ReadLine());

        temp = num;

        while (num > 0)
        {
            remainder = num % 10;
            //reverseの使い方に気を付ける
            reverse = reverse * 10 + remainder;

            num /= 10;
        }

        Console.WriteLine("Given number is = {0}", temp);
        Console.WriteLine("Its reverse is  = {0}", reverse);

        if (temp == reverse)
            Console.WriteLine("Number is a palindrome \n");
        else
            Console.WriteLine("Number is not a palindrome \n");
        Console.ReadLine();¥

    }
}


//文字列を反転させたい場合はLinqのReverse()を使えばいい　
//そうすると逆順のIEnumerable<char>を得ることができる
public void Sub()
{
    var s = "139738108324";
    var rev = new string (s.Reverse().ToArray());
    Console.WriteLine(rev);
}