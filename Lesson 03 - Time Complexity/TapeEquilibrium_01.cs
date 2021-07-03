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
using System.Linq;

class Solution {
    public int solution(int[] A) {

        int sumLeft = A[0];
        int sumRight = A.Skip(1).Sum();
        int minAbsDiff = Math.Abs(sumLeft - sumRight);

        for(var index = 1; index < A.Length - 1; index++)
        {
            sumLeft += A[index];
            sumRight -= A[index];
            
            int absDiff = Math.Abs(sumLeft - sumRight);
            if(absDiff < minAbsDiff)
            {
                minAbsDiff = absDiff;
            }
        }
        return minAbsDiff; 
    }
}