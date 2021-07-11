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
        
        Array.Sort(A);
        
        var maxProduct = A[A.Length-1] * A[A.Length -2] * A[A.Length -3];
        
        if(A[0] < 0 && A[1] < 0)
        {
            var maxProductOfNeg = A[0] *A[1] * A[A.Length-1];
            if(maxProductOfNeg > maxProduct)
            {
                maxProduct = maxProductOfNeg;
            }
        }

        return maxProduct;
    }
}
