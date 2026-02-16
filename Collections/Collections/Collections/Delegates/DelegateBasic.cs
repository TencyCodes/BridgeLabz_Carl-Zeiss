using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Delegates
{
    internal class DelegateBasic
    {
        public delegate void NotifyUser(string message);
        
            public static void SendMail(string message)
            {
                Console.WriteLine($"Mail : {message}");
            }
            public static void SMS(string message)
            {
                Console.WriteLine($"SMS : {message}");
            }
             public static void LOG(string message)
            {
                Console.WriteLine($"LOG : {message}");
            }
        
        static void Main(String[] args)
        {
            //NotifyUser noti = SendMail;
            //noti("Order is Ready");
            NotifyUser notis = SendMail;
            notis += SMS;
            notis += LOG;
            notis("order ready");
            
        }
        //public class OrderProcessor
        //{
        //    public void ProcessOrder(string order, NotifyUser notification)
        //    {
        //        Console.WriteLine($"Order Processing for item {order}....");
        //        Thread.Sleep(1000);

        //        Console.WriteLine($"Order for {order} completed");
        //    }
        //    static void Main(string[] args)
        //    {
        //        OrderProcessor order1 = new OrderProcessor();
        //        order1.ProcessOrder("Laptop", SendMail);
        //        Thread.Sleep(1000);
        //        order1.ProcessOrder("Phone", SMS);
        //    }
           
           
        }
    }
    

