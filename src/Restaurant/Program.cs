using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
             restaurant work= new restaurant(); 
             
             Boolean billstatus=work.bill();
             if(billstatus){
             work.feedback();
             }
             else{
                 Console.WriteLine("Please pay the bill");
             }
        }
    }
}
