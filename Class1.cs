using Delegates_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_library
{
    delegate string delegate_method(string str);
   
}
public class Len
{
    static string Length(string s)
    {
        string temp = "";
        int i, j;
        Console.WriteLine("Length String...");
        for (j = 0, i = s.Length - 1;
            i >= 0; i--, j++)
            temp += s[i];
        return temp;
    }
    static void Main(string[] args, string Anita)
    {
        delegate_method del = new delegate_method(Length);
        string str;
        del = new delegate_method(Length);
        str = del("Hello" + Anita);
        Console.WriteLine("Result is: " + str);
       
    }
}
    

