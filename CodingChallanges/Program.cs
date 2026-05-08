// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int[] TwoSum(int[] nums, int target)
//{
//    int[] result = new int[2];
//    if (nums.Length <= 2 || nums.Length >= Math.Pow(10, 4)) return result;

//    int first;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        first = nums[i];
//        for (int j = 0; j < nums.Length; j++)
//        {
//            int second = nums[j];
//            if (first + second == target)
//            {
//                result[0] = i;
//                result[1] = j;
//                return result;
//            }
//        }
//    }

//    return result;
//}

//int[] result = TwoSum([4, 9, 11, 6, 8], 14);
//Console.WriteLine($"{result[0]}, {result[1]}");

//string LongestCommonPrefix(string[] strs)
//{
//    string result = "";
//    int length = strs[0].Length;

//    for(int i = 0; i < length; i++ )
//    {
//        char currentChar = strs[0][i];
//        bool isTheSame = true;
//        for(int j = 1; j < strs.Length; j++)
//        {
//            if (strs[j].Length <= i || strs[j][i] != currentChar)
//            {
//                isTheSame = false;
//                break;
//            }
//        }
//        if (isTheSame)
//        {
//            result += currentChar;
//        }
//        else
//        {
//            break;
//        }
//    }

//    return result;
//}

//string result = LongestCommonPrefix(["flower", "flow", "flight"]);
//Console.WriteLine($"{result}");

int RemoveElement(int[] nums, int val)
{
    if(nums.Length < 0 || nums.Length > 100) return 0;
    if(val  < 0 || val > 100) return 0;

    int count = 0;

    for(int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            continue;
        }
        else
        {
            count++;
        }
    }

    Console.WriteLine($"count - {count}");

    int[] newNums = new int[nums.Length - count];

    int index = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            newNums[index] = nums[i];
            index += 1;
        }
    }

    for(int i = 0; i < newNums.Length; i++)
    {
        Console.WriteLine(newNums[i]);
    }

    nums = newNums;
    return count;
}

int result = RemoveElement([3, 2, 2, 3], 3);
Console.WriteLine(result);