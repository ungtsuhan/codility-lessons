///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 11 July 2021
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
            return 0;
            
        Array.Sort(A);
        var currentNum = A[0];
        var distinctCount= 1;
        
        for(var i = 1; i < A.Length; i++)
        {
            if(A[i] != currentNum)
            {
                distinctCount++;
                currentNum = A[i];
            }
        }
        return distinctCount;
    }
}
