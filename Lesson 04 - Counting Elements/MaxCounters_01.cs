///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 30 June 2021
// Total Score  : 77%
// Task Score   : 77%
// Correctness  : 100%
// Performance  : 60%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;

class Solution {
    public int[] solution(int N, int[] A) {
        
        int[] arr = new int[N];
        Array.Clear(arr, 0, arr.Length);
        
        int maxCounter = 0;

        for(int index = 0; index < A.Length; index++)
        {
            if(A[index] <= N)
            {
                int arrIndex = A[index]-1;
                arr[arrIndex]++;

                if(arr[arrIndex] > maxCounter)
                {
                    maxCounter = arr[arrIndex];
                }
            }
            else
            {
                for(int i = 0; i < arr.Length; i++){
                    arr[i] = maxCounter;
                } 
            }
        }
        return arr;
    }
}