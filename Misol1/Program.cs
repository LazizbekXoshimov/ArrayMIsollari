int[] nums = new int[6] { 0, 2, 1, 5, 3, 4 };
int[] ans = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    ans[i] = nums[nums[i]];
}
foreach (int i in ans)
{
    Console.Write(i + " ");
}