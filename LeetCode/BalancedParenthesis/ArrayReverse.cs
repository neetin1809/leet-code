using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public sealed class ArrayReverse
{
	public ArrayReverse()
	{

	}
	
	public List<int> OccurenceInArray(int num)
    {
		int len = 6;
		int []arr = new int[6];
		//Hold the result
		List<int> result = new List<int> ();
		int key = 0;

		//Algorithm
		int min = 0, max = len-1, mid;

		while(min <= max)
        {
			mid = (min+max)/2;

			//
			if (key == arr[mid])
            {
				result.Add (mid);
				mid++;
            }

			if(arr[mid]> key)
            {
				max = mid - 1;
            }
            else
            {
				min = mid + 1;
            }

        }
		return result;
    }

	public List<int> RepeatNumbersInArray(int[] arr)
	{
		//Variables Needed for Calculation 
		int mid = arr.Length / 2;
		int len = arr.Length - 1;

		//result
		List<int> result = new List<int>();

		for (int i = 0; i <= mid; i++)
		{
			int key = arr[i];

			//Needed for Caparsion
			for (int j = i; j <= mid; j = i++)
			{
				//Avoid Campasrion of mid twice
				if (j != len - j)
				{
					if (arr[j] == arr[len - j] && arr[j] == key && !result.Any(x => x == key))
					{
						result.Add(key);
					}
				}
			}
		}
		return result;

	}

	public void ReverseArray(int len)
	{
		int[] arr = new int[len];
		int mid = len / 2;

		for (int i = 0; i < len - 1; i++)
		{
			arr[i] = System.Convert.ToInt32(Console.ReadLine());
		}

		for (int i = 0; i <= mid; i++)
		{
			if ((i != len - 1 - i))
			{
				//Swapping without using third variable
				arr[i] = arr[i] + arr[len - i - 1];
				arr[len - i - 1] = arr[i] - arr[len - i - 1];
				arr[i] = arr[i] + arr[len - i - 1];
			}
		}
	}


	public  int Search(int[] nums, int target)
	{
		var startIndex = 0;
		var endIndex = nums.Length - 1;
		while (startIndex <= endIndex)
		{
			//Instead of using  midPoint = (start + end)/2  to calculate the midpoint,
			//we use midPoint = start + (end - start)/2 to prevent integer overflow
			var midPoint = startIndex + (endIndex - startIndex) / 2;

			//we found the target, return the array index
			if (nums[midPoint] == target)
				return midPoint;
			//Value inside the array is higher than the target value, move endIndex to midPoint -1
			if (nums[midPoint] > target)
				endIndex = midPoint - 1;
			//Value inside the array is lower than the target value, move startIndex to midPoint +1
			else startIndex = midPoint + 1;
		}
		// return startIndex, this is the index where the target should've been stored in the array
		return startIndex;
	}
}
