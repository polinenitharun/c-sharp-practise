using System;
using System.Collections.Generic;

namespace Restaurant{
    class restaurant{
        List<int> order=new List<int>();
        Boolean billstatus=true;
        
        public restaurant(){
            Console.WriteLine("Please enter the order type");
             Console.WriteLine("OrderAtPlace : Press 1\n Order for Delivery : Press 2");
             int ordertype=Convert.ToInt32(Console.ReadLine());
            
             if(ordertype==1){
                 Console.WriteLine("Enter the table number of the customer");
                 int tablenumber=Convert.ToInt32(Console.ReadLine());
                 Order();
             }
             if(ordertype==2){
                 Console.WriteLine("Enter the name of the customer");
                 String name=Console.ReadLine();
                 Order(name); 
             }
        }
        public void Order(){
            Console.WriteLine("Take the order from the customer");
            Console.WriteLine("1 : pizza\n 2 : burger\n 3 : soup\n 10 : finished taking order\n");
            for(;;){
                String x=Console.ReadLine();
                int y=Convert.ToInt32(x);
                if(y!=10){
                    if((y>=1&& y<=3)){
                    order.Add(y);
                    }
                    else{
                        Console.WriteLine("Please enter the valid order");
                    }
                }
                else{
                    break;
                }
            }
        }
        public void Order(String name){
            Console.WriteLine("Take the order from the customer");
            Console.WriteLine("1 : pizza\n 2 : burger\n 3 : soup\n 10 : finished taking order\n");
            for(;;){
                String x=Console.ReadLine();
                int y=Convert.ToInt32(x);
                if(y!=10){
                    order.Add(y);
                }
                else{
                    break;
                }
            }
        }
        public bool bill(){
            int[] price=new []{ 100, 150, 100 };
            int sum=0;
            for(int i=0;i<order.Count;i++){
                sum+= price[order[i]-1];
            }
            Console.WriteLine("The final bill of tablenumber " + "is " + sum);
            Console.WriteLine("Enter 1 if bill is paid else enter 2");
            int statusofbill=Convert.ToInt32(Console.ReadLine());
            if(statusofbill==1){
                billstatus=true;
            }
            else{
                billstatus=false;
            }
            return billstatus;
        }
        public void feedback(){
            Console.WriteLine("Please enter your feedback on a scale of 1-10");
            int feedback=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Thanks for the feedback of {feedback}");
        }
    }
}