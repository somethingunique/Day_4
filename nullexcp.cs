using System;
namespace Program
{
    public class MyException:ApplicationException
    {
        public void MyIndexOutOfRangeException()
        {
            Console.WriteLine("Exception occured, index is out of range");
        }
    }
    public class Class6
    {
        public static void Main()
        {
            int []a=new int[2];
            try
            {
                if(1==1){
                //a[3]=8;
                throw new MyExpection();
                }
            }
            catch(MyException ex)
            {
                ex.MyIndexOutOfRangeException();
            }
            Console.ReadLine();
        }
    }
}