using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLibrary
{
    public class HelloWorldLibrary
    {
        public static string Concatenation(string username)
        {
            return $"{ DateTime.Now} Hello, {username}!";
        }
    }
}
