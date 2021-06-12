public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int right = 0;
        int mindist = nums.Length+1;
        int dist = 0;
        int sum=0;
        while(left<=right && right<nums.Length)
        {
            sum+=nums[right];
            while(sum >= target)
            {
                mindist = Math.Min(mindist, right-left+1);
                sum-=nums[left];
                left++;
            }
            right++;
        }
        return (mindist!=nums.Length+1)?mindist:0;
        
    }
}