using System;
using System.Collections.Generic;

namespace A002
{
    class Program
    {
        static void Main(string[] args)
        {

            //ListNode<int> a1 = new ListNode<int>(2);
            //ListNode<int> a2 = new ListNode<int>(4);
            //ListNode<int> a3 = new ListNode<int>(3);
            //a1.next=a2;
            //a2.next=a3;

            //ListNode<int> b1 = new ListNode<int>(5);
            //ListNode<int> b2 = new ListNode<int>(6);
            //ListNode<int> b3 = new ListNode<int>(4);
            //b1.next=b2;
            //b2.next=b3;
            ListNode<int> a1 = new ListNode<int>(9);
            ListNode<int> a2 = new ListNode<int>(9);
            ListNode<int> a3 = new ListNode<int>(9);
            a1.next=a2;
            a2.next=a3;

            ListNode<int> b1 = new ListNode<int>(1);

            ListNode<int> ln = AddTwoNumbers(a1,b1);
            while(ln!=null){
                Console.WriteLine(ln.value);
                ln=ln.next;
            }
            Console.ReadKey();
        }

        public static ListNode<int> AddTwoNumbers(ListNode<int> l1,ListNode<int> l2)
        {
            ListNode<int> result= new ListNode<int>(0);
            ListNode<int> current =null;
            int overflow = 0;
            while(l1!=null||l2!=null||overflow!=0)
            {
                var l1value = l1==null ? 0 : l1.value;
                var l2value = l2==null ? 0 : l2.value;

                int sum = l1value+l2value+overflow;

                overflow=sum/10;
                var newNode = new ListNode<int>(sum%10);
                if(current==null){
                    current=newNode;
                    result=current;
                }
                else{
                    current.next=newNode;
                    current=newNode;
                }
                if(l1!=null) l1=l1.next;
                if(l2!=null) l2=l2.next;
            }

            return result;
        }

        public class ListNode<T> {
            public T value;
            public ListNode<T> next=null;

            public ListNode(T value)
            {
                this.value=value;
            }
        }
    }

}
