using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {  
       
        static void Main(string[] args)
        {   
            //DISEMVOWELER CALLS HERE with ORIGINAL printed and DEVOWELED printed
            Console.WriteLine("Original: Nickleback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine("Devoweled: " + Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!"));

            Console.WriteLine("Original: How many bears could Bear Grylls grill if Bear Grylls could grill bears?");
            Console.WriteLine("Devoweled:  " + Disemvoweler("How many bears could Bear Grylls grill if Bear Grylls could grill bears? "));

            Console.WriteLine("Original: I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.WriteLine("Devoweled: " + Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls. "));

            Console.ReadKey();
        } 
        
        //declare function "Disemvowel" with a parameter of "inString"
        static string Disemvoweler(string inString)
        {
            
            string returnString = " ";
            string vowels = " ";

            //begin for loop and if statement
            for (var i = 0; i < inString.Length; i++)
            {
                var c = inString[i];
                //if statement telling the loop to remove the vowels for the parameter 
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == ' ')
                {
                
                    if (c != ' ')
                    {
                        vowels += c;
                    }
                    
                }
                else
                {
                    returnString += c;
                }
                
                
            }
            return returnString;

            
         }
       
    }
}

    

   
