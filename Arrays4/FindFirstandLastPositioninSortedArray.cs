public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
          int[] result = new int[2];
            
            int lastoccurance = 0;
            int count = 0; int firstoccurance = 0; 
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] == target)
                { 
                    if(count == 0)
                       firstoccurance = i;
                    count++;
                    lastoccurance = i;

                }
            }
            if (count >= 1)
            {
                result[0] = firstoccurance;
                result[1] = lastoccurance;
                
            }
            else if (count == 0)
            {
                result[0] = -1;
                result[1] = -1;               

            }           
            

            return result;
        
    }
}