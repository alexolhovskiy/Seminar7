/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.


Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    //(#47)Set matrix  
    PrintMatrix(MakeArr(ArrQuery()));
    MyClear();
    
    //(#50)Element search by value
    int[,]arr_int=MakeArr_int(ArrQuery());
    PrintMatrix(arr_int);
    Console.WriteLine("Enter element");
    int num=int.Parse(Console.ReadLine());
    PrintArr(FindElement(arr_int,num));
    MyClear();
    
    //(#52)Search for the column average
    arr_int=MakeArr_int(ArrQuery());
    PrintMatrix(arr_int);
    PrintArr(Average(arr_int));
    MyClear();
  }
  
  
  public static double[]Average(int[,]arr)
  {
      double[]averageArr=new double[arr.GetLength(1)]; 
      
      for(var j=0;j<arr.GetLength(1);j++)
      {
          averageArr[j]=0;
      }
      
      for(var i=0;i<arr.GetLength(0);i++)
      {
          for(var j=0;j<arr.GetLength(1);j++)
          {
              averageArr[j]+=arr[i,j];
          }
      }
      
      for(var j=0;j<arr.GetLength(1);j++)
      {
          averageArr[j]/=arr.GetLength(0);
      }
      return averageArr;
  }
  
  public static int[]FindElement(int[,]arr,int element)
  {
      int[]point=new int[2]; 
      point[0]=-1;
      point[1]=-1;
      for(var i=0;i<arr.GetLength(0);i++)
      {
          for(var j=0;j<arr.GetLength(1);j++)
          {
              if(arr[i,j]==element)
              {
                  point[0]=i;
                  point[1]=j;
                  return point;
              }
          }
      }

      Console.WriteLine("Element doesn't exist");
      return point;
  }
  
  public static int[]ArrQuery()
  {
      int[]arr=new int[4];
      Console.WriteLine("Enter num of rows");
      arr[0]=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter num of columns");
      arr[1]=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter min value");
      arr[2]=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter max value");
      arr[3]=int.Parse(Console.ReadLine());
      return arr;
  }
  
  public static double[,]MakeArr(int[]param)
  {
      double [,]arr=new double[param[0],param[1]];
      Random rand=new Random();
      for(var i=0;i<param[0];i++)
      {
          for(var j=0;j<param[1];j++)
          {
              arr[i,j]=param[2]+rand.NextDouble()*(param[3]-param[2]);
          }
      }
      return arr;
  }
  
  
  public static int[,]MakeArr_int(int[]param)
  {
      int [,]arr=new int[param[0],param[1]];
      Random rand=new Random();
      for(var i=0;i<param[0];i++)
      {
          for(var j=0;j<param[1];j++)
          {
              arr[i,j]=rand.Next(param[2],param[3]);
          }
      }
      return arr;
  }
  
  
  public static void MyClear()
  {
      Console.WriteLine("Press Enter key");
      Console.ReadLine();
      Console.Clear();
  }
  
  public static void PrintArr(double[]arr)
  {
      for(int i=0;i<arr.Length;i++)
      {
          Console.Write($"{arr[i]:f2} ");
      }
      Console.WriteLine();
  }
  
  public static void PrintArr(int[]arr)
  {
      for(int i=0;i<arr.Length;i++)
      {
          Console.Write($"{arr[i]} ");
      }
      Console.WriteLine();
  }
  
  public static void PrintMatrix(double[,]arr)
  {
      for(var i=0;i<arr.GetLength(0);i++)
      {
          for(var j=0;j<arr.GetLength(1);j++)
          {
              Console.Write($"{arr[i,j]:f2} ");
          }
          Console.WriteLine();
      }
      Console.WriteLine();
  }
  
  public static void PrintMatrix(int[,]arr)
  {
      for(var i=0;i<arr.GetLength(0);i++)
      {
          for(var j=0;j<arr.GetLength(1);j++)
          {
              Console.Write($"{arr[i,j]} ");
          }
          Console.WriteLine();
      }
      Console.WriteLine();
  }
}

