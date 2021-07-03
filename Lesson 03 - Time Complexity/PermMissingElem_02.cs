///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 29 June 2021
// Total Score  : 100%
// Task Score   : 100%
// Correctness  : 100%
// Performance  : 100%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;

class Solution {
    public int solution(int[] A) {
        if(A.Length == 0)
            return 1;

        Array.Sort(A);
        int largestNum = A[A.Length-1];
        int smallestNum = A[0];
        
        if(largestNum - smallestNum == 0 || largestNum - smallestNum == (A.Length - 1))
        {
            if(smallestNum == 1)
            {
                return largestNum + 1;
            }
            else
            {
                return smallestNum - 1;
            }
        }
        else
        {
            for(var i = 0; i < A.Length; i++)
            {
                if(A[i] != smallestNum+i)
                    return smallestNum+i;
            }
            return 1;
        }
    }
}