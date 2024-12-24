public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int index1 = m - 1, index2 = n - 1;
        int i = m + n - 1;
        while(i >= 0)
        {
            if(index1 >= 0)
            {
                if(index2 >= 0)
                {
                    // if both indices are not zero means there needs comparision to be done b/w their elements
                    if(nums1[index1] <= nums2[index2])
                    {
                        // if array 2's element is larger then store it at last indices of the array 1
                        nums1[i] = nums2[index2];
                        index2--;
                        i--;
                    } else
                    {
                        // if not, then store array 1's element at the last indices of the array 1
                        nums1[i] = nums1[index1];
                        index1--;
                        i--;
                    }
                } else
                {
                    // if index2 = 0, means all elements of the second array are placed at their correct position
                    // now just place the remaining elements of the array 1 in the remaining position in array 1
                    nums1[i] = nums1[index1];
                    index1--;
                    i--;
                }
                
            } else
            {
                // if index1 = 0, means all elements of the first array are placed at their correct position
                // now just place the remaining elements of the array 2 in the remaining position in array 1
                nums1[i] = nums2[index2];
                index2--;
                i--;
            }
        }
    }
}

// Idea here is to use the n no. of zeroes and start filling them with the largest numbers of the two arrays.
