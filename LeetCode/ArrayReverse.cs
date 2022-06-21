using System;

public sealed class ArrayReverse
{
	public ArrayReverse()
	{

	}
	
	public List<int> RepeatNumbersInArray(int[] arr)
    {
		//Variables Needed for Calculation 
		int mid = arr.length / 2;
		int len = arr.length - 1;

		//result
		List<int> result;

        for (int i = 0; i <= mid; i++)
        {
			int key = arr[i];

			//Needed for Caparsion
            for (int j = i; j  <= mid; j = i++)
            {
				//Avoid Campasrion of mid twice
				if (j != len - j)
				{
					if (arr[j] == arr[len - j] && arr[j] == key && !result.Any(x => x == key))
					{
						.Add(key);
					}
				}
            }
        }
		return result

	}

	public List<int> OccurenceInArray(int num)
    {
		int len = 6;
		int arr[6];
		//Hold the result
		List<int> result = new List<int> ();
		int key;

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

	public void ReverseArray(int len)
	{
		int[] arr = new int[len];
		int mid = len / 2;

        for (int i = 0; i < length-1; i++)
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
}