﻿using System;

namespace homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Hello this is my homework" };

            foreach (string join in array)
            {
                foreach (char text in join)
                {
                    if (char.IsUpper(text))
                    {
                        Console.Write(char.ToLower(text));
                    }
                    else
                    {
                        Console.Write(char.ToUpper(text));
                    }
                    

                }
            }
        }
      
        

         
     
    }
}
