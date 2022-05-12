using System;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                var prev = nums[i - 1];
                var cur = nums[i];

                if (cur != prev)
                {
                    if (k < i)
                    {
                        nums[k] = cur;
                    }
                    k++;
                }
            }

            return k;
        }

        static void Main(string[] args)
        {
            int[] nums = new[]
            {
                -100,0,100,100
            };
            var k = RemoveDuplicates(nums);
            Console.WriteLine(k);

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
