using System;
using static System.Console;

namespace Bme121
{
    static class Program
    {
        static void Main( )
        {
            Write( "Enter a number: " );
            int number=int.Parse( ReadLine( ) );//asks for number 
            int numTwo=number; //multiple numbers easier to stick with another variable 
            Write( "Enter a base: " );
            int baseValue=int.Parse( ReadLine( ) );//base
            int counter=0;
            
            if(number < 0 || baseValue < 2)
            
            {
                WriteLine( "Invalid entry!" );
                return;
            }
            
            for(int index = number; index > 0; index = index/baseValue)//counts digits
            {
                counter++;
            }
            
            int[] array= new int[counter];//allocate array 
            
            for(int index = 0; index < array.Length; index++)//stores digits
            {
                array [index] = number % baseValue;
                number = number / baseValue;
            }
            
            Write( numTwo + " in base " + baseValue + " is " );//display
            
            for ( int index = counter-1; index >= 0; index--)  //reverse aka from most to least
            {
                Write(array [index]  );
                if (baseValue > 9)
                {
                    if ( index > 0)
                    {
                        Write(" , ");
                    
                    }
                }
            }
            
        
            
                
            
            
            
            
            
            
            
        }
    }
}
