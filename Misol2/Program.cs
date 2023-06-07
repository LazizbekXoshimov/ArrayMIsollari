int[] nums = new int[] { 1, 3, 2, 1 };
int[] ans = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    ans[i] = nums[i];
    ans[i+nums.Length] = nums[i];
}
foreach (int n in ans)
{
    Console.Write(n + " ");
}