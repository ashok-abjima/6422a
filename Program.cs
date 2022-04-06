using System;
//GENERICS in c#
class Stud <T,T1>
{
    public T i;
    public T1 j;
}
class Program
{
    static void Main ()
    {
        Stud <int,string> obj = new Stud<int,String> ();
        obj.i = 1;
        
        obj.j = ".Ashok";

        Console.WriteLine ("{0}{1}",obj.i,obj.j);
        Console.ReadKey ();
    }
}
