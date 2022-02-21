using System;
using System.Threading;

class Program 
{
    

    static void Main(String[] args)
    {
        int previousRowSize = 0;
        int[] previousTriangle = {};
        int rowSize = 0;
        Console.WriteLine("Enter shit now");
        int userInput = Convert.ToInt32(Console.ReadLine());
        string[] pascalsTriangle = new string[userInput];

        Console.WriteLine("Running");
        for(int i = 0; i != userInput;i++)
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

                triangle[k] = previousTriangle[k]+previousTriangle[k-1];
            }

            pascalsTriangle[i] = IntListWrite(triangle);
            previousRowSize = rowSize;
            previousTriangle = triangle;

        }

        int lastRowLength = pascalsTriangle[pascalsTriangle.Length-1].Length;
        string space = " ";
  
        int x = pascalsTriangle[userInput-1].Length;
        for(int p=userInput-1;p>=0 ;p--)
            {

                while( x >= pascalsTriangle[p].Length)
                {
                    pascalsTriangle[p] = space+pascalsTriangle[p]+space;
    
                }
        
            }
        Console.WriteLine(StringListWrite(pascalsTriangle));

    
    static string IntListWrite(int[] a )
    {   
        string result = "";
        for(int j = 0; j!=a.Length; j++)
        {
            result += a[j]+" ";            
        }

        return result;

    }

    static string StringListWrite(string[] a )
    {   
        string result = "";
        for(int j = 0; j!=a.Length; j++)
        {
            result += a[j]+"\n";            
        }

        return result;

    }



    }
}