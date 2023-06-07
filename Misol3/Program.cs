int n = 4;
int[] nums = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
int[] Sinse = new int[nums.Length];
int count = 0;
for (int i = 0; i < nums.Length / 2; i++)
{
    Sinse[count] = nums[i];
    Sinse[count + 1] = nums[i + n];
    count += 2;
}
foreach (var item in Sinse)
{
    Console.Write(item + " ");
}