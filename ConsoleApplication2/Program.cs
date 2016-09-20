using System;

class Program
{
    static void Main()
    {
        //A string is a class, which can be instantiated like this
        string s = "Hi there";
        Console.WriteLine(s);//Hi there
        ChangeString(s);
        Console.WriteLine(s);//Hi there
        ChangeString(ref s);
        Console.WriteLine(s);//s is now a null reference
    }

    static void ChangeString(string str)
    {
        str = null;
    }

    static void ChangeString(ref string str)
    {
        str = null;
    }
}