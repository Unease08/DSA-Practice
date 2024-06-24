public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int> ();

        foreach(int num in nums) {
            if (set.Contains(num)) return true;
            set.add(num);
        }
        return false
    }
}