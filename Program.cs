using System;
using System.Threading;

class Program 
{
    

    static void Main(String[] args)
    {
        
        
        Console.WriteLine("Welome to Pascal's Triangle!");
        Console.Write("Please enter the number of rows you would like to be displayed: ");
        int userInput = Convert.ToInt32(Console.ReadLine());


        int previousRowSize = 0;
        int rowSize = 0;
        string[] pascalsTriangle = new string[userInput];
        int[] previousTriangle = {};

        for(int i = 0; i != userInput;i++)
        {

            rowSize++;

            //create list for num of new row
            int[] triangle= new int[rowSize];
            int rowsLeft = rowSize;
            //makes first and last digits 1
            triangle[0] = 1;
            triangle[triangle.Length-1] = 1;
           
            //does loop after first 2 rows are complete 
            for(int k=1; k <= rowsLeft && rowSize > 2; k++)
            {
                //if loop reaches the last digit it ends
                if(triangle.Length-1 == k)
                {
                    break;
                }
                //adds the current positoin and previous position of the previous rowes to gether to create new row
                triangle[k] = previousTriangle[k]+previousTriangle[k-1];
            }

            pascalsTriangle[i] = IntListWrite(triangle);
            previousRowSize = rowSize;
            previousTriangle = triangle;

        }


        int x = pascalsTriangle[userInput-1].Length;
        //loop for every row
        for(int p=userInput-1;p>=0 ;p--)
            {
                //loops for every digit in a row 
                //add spaces untill length is equal to last row
                while( x >= pascalsTriangle[p].Length)
                {
                    
                    pascalsTriangle[p] = " "+pascalsTriangle[p]+" ";
    
                }
        
            }
        //displays the final product
        Console.WriteLine(StringListWrite(pascalsTriangle));

    //turns int list into a string 
    static string IntListWrite(int[] a )
    {   
        string result = "";
        for(int j = 0; j!=a.Length; j++)
        {
            result += a[j]+" ";            
        }

        return result;

    }

    //used to turn a string list into string 
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