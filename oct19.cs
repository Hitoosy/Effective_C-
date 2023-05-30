using System;
using System.Collections.Generic;
using System.Linq;

public class oct19
{
    public static void Main(string[] arg)
    {
       var seq = new List<Foo> {
           new Foo { Id = 2 }, new Foo { Id = 0 }, new Foo { Id = 1},
        };

       var query = from x in seq
                   select x.Id;

        Console.WriteLine("----loop start!!-----");
        foreach(var q in query)
        {
            Console.WriteLine("{0}", q);
        }
    }
}



public class Foo
{
    private int id;

    public int Id{
        get {
            Console.WriteLine("call get id {0}", id);
            return id;
        }
        set => id = value;
    }
}