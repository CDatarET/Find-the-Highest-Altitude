public class Solution {
    public int LargestAltitude(int[] gain) {
        int max = 0;
        int alt = 0;
        for(int i = 0; i < gain.Length; i++){
            alt += gain[i];
            max = Math.Max(alt, max);
        }
        return(max);
    }
}
