/* 
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Input: nums = [2,7,11,15], target = 9

Output: [0,1]

Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

nested loop?

*/


int[] TwoSum(int[] nums, int target)
{
    var numberToIndex = new Dictionary<int, int>();

    for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
    {
        int currentNumber = nums[currentIndex];
        int requirednumber = target - currentNumber;

        if (numberToIndex.ContainsKey(requirednumber))
        {
            return new int[] { numberToIndex[requirednumber], currentIndex };

        }

        if (!numberToIndex.ContainsKey(currentNumber))
        {
            numberToIndex[currentNumber] = currentIndex;

        }
    }

    throw new InvalidOperationException("No solution.");
}
