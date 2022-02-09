using System;
using System.Threading;

class Program 
{
    

    static void Main(String[] args)
    {
        int previousRowSize = 0;
        int[] previousTriangle = {0};
        int rowSize = 0;
        int userInput = Convert.ToInt32(Console.ReadLine());
        int gapSize = Convert.ToInt32(Math.Ceiling(userInput*0.5f));
        string space = " ";
        string gap = "";
        


        for(int i = 0; i != Convert.ToInt32(userInput);i++)
        {

            rowSize++;


            int[] triangle= new int[rowSize];
            //Console.WriteLine("Triangle Array Lenght " + triangle.Length);


            int rowsLeft = rowSize;
            triangle[0] = 1;
            triangle[triangle.Length-1] = 1;
            //Console.WriteLine("triangle length: "+triangle.Length);
            
            for(int k=1; k <= rowsLeft && rowSize > 2; k++)
            {
                
                if(triangle.Length-1 == k)
                {
                    break;
                }
               
                //Console.WriteLine("repeate: " + k);
                triangle[k] = previousTriangle[k]+previousTriangle[k-1];
            }


            previousRowSize = rowSize;
            previousTriangle = triangle;


            for(int b=0; b <= gapSize; b++)
            {
                gap += space;
        
            }

            
            Console.WriteLine(gap+IntListWrite(triangle));
            gapSize -= 1;
            gap = "";






       
        }

    
    static string IntListWrite(int[] a)
    {   
        string result = "";
        for(int j = 0; j!=a.Length; j++)
        {
            result += a[j] + " ";            
        }

        return result;

    }

    }
}