using System;
using System.Collections.Generic;

namespace A001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = TwoSum(new int[] { 2,7,11,15 },9);
            //Console.WriteLine(a.Length);
            Console.WriteLine(a[0].ToString()+a[1].ToString());
        }

        public static int[] TwoSum(int[] nums,int target)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for(int i = 0;i<nums.Length;i++)
            {
                int require = target-nums[i];
                if(dict.ContainsKey(require))
                {
                    return new int[] { i,dict[require] };
                }
                else
                {
                    dict[nums[i]]=i;
                    //dict.Add(nums[i],i);
                }
            }

            return null;
        }
    }
}
