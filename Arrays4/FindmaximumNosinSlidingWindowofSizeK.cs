public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
       var result = new List<int>();
        var deque = new LinkedList<int>();
        for (int i = 0; i < nums.Length; i++) 
        {   
            if (deque.Any() && deque.First.Value <= i - k)
                deque.RemoveFirst();
            
            while (deque.Any() &&  nums[i] >= nums[deque.Last.Value])
                deque.RemoveLast();
            
            deque.AddLast(i);

            if(i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }
        
        return  result.ToArray();
    }
}