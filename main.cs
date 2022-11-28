using System;

class Maths {
    public static void min (int a, int b){
        if(a>b){
            Console.WriteLine("Value of min number : "+b);
        }
        else if(a==b){
            Console.WriteLine("Values are equal and value of min number: "+b);
        }
        else if(b>a){
            Console.WriteLine("Value of min number: "+a);
        }
        else{
            Console.WriteLine("error");
        }
    }
    
    public static void max (int a, int b){
        if(a>b){
            Console.WriteLine("Value of max number : "+a);
        }
        else if(a==b){
            Console.WriteLine("Values are equal and value of max number: "+b);
        }
        else if(b>a){
            Console.WriteLine("Value of max number: "+b);
        }
        else{
            Console.WriteLine("error");
        }
    }
    
    public static int factorial(int a){
        if(a<0){
            Console.WriteLine("Entered value less than zero");
            return 0;
        }
        if(a==0){
            return 1;
        }
        return a * factorial(a - 1);
    }
    
    public static void SortedArray(int[] arr, int length){
        int i, j, temp;
        for (i = 1; i < length; i++){
            temp = arr[i];
            j = i - 1;
            while (j >= 0 && arr[j] > temp){
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = temp;
        }
        
        Console.WriteLine("\nSorted array : ");
        for (i = 0; i < length; i++){
                Console.Write(arr[i] + "\n");
        }
    }
    
    static void Main(string[] args) {
      Console.WriteLine("Select the operation you want to do\n");
      Console.WriteLine("1-To find min\n");
      Console.WriteLine("2-To find max\n");
      Console.WriteLine("3-To find factorial\n");
      Console.WriteLine("4-To find sorted array\n");
      int choice= Convert.ToInt32(Console.ReadLine());
      if(choice==1){
          Console.WriteLine("Enter two value to find min");
          int value1 = Convert.ToInt32(Console.ReadLine());
          int value2 = Convert.ToInt32(Console.ReadLine());
          min(value1,value2);
      }
      else if(choice==2){
          Console.WriteLine("Enter two value to find min");
          int value1 = Convert.ToInt32(Console.ReadLine());
          int value2 = Convert.ToInt32(Console.ReadLine());
          max(value1,value2);
      }
      else if(choice==3){
          Console.WriteLine("Enter a value to find factorial");
          int value3 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("factorial of given number: "+ factorial(value3));
      }
      else if(choice==4){
          int[] arr = { 7, 5, 8, 24, 11, 17, 1};
          int length = 7;
          SortedArray(arr, length);
      }
      else{
          Console.WriteLine("Error");
      }
          
    }
}
