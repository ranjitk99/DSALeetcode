public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        
         int left = 0;
        int right = arr.Length - k;
        while(left < right){
            int mid = left + (right - left) / 2;
            if(x - arr[mid] > arr[mid + k] - x){
                left = mid + 1;
            }else{
                right = mid;
            }
        }
        int[] result = new int[k];
        for(int i=0;i<k;i++){
            result[i] = arr[left + i];
        }
        return result;
    }
}