int[] nums = {3, 2, 2, 3, 2, 4, 4, 5, 5, 3, 2, 5, 6, 7, 6, 8};
System.Console.WriteLine(nums);
int size = nums.Length;
int max = nums[0];
for (int i = 1; i < size; i++)
    if (nums[i] > max) max = nums[i];

int[] counter = new int[max+1];

for (int i = 0; i < size; i++)
    counter[nums[i]]++;

int index = 0;
for (int i = 0; i < max + 1; i++)
    for (int j = 0; j < counter[i]; j++)
        nums[index++] = i;

System.Console.WriteLine($"{String.Join(",", nums)}");