
public class Solution {
    public static int MinMeetingRooms(int[][] intervals) {
         if (intervals == null || intervals.Length == 0)
            return 0;
        
        int result = 0;
        int[] starts = new int[intervals.Length],
              ends = new int[intervals.Length];
        
        for (int i = 0; i < intervals.Length; i++)
        {
            starts[i] = intervals[i][0];
            ends[i] = intervals[i][1];
        }
        
        Array.Sort(starts);
        Array.Sort(ends);
        
        for (int i = 0, j = 0; i < starts.Length; i++)
            if (starts[i] < ends[j])
                result++;
            else
                j++;
        
        return result; 
        
    }

    


}