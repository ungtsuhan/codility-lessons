///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 29 June 2021
// Total Score  : 70%
// Task Score   : 70%
// Correctness  : 100%
// Performance  : 40%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        if(A.Length == 0)
            return 1; 

        var minNum = A.Min();
        var maxNum = A.Max();

        var arr = Enumerable.Range(minNum, maxNum - minNum + 1).ToArray();
        var missingNum = arr.Where(u => Array.IndexOf(A, u) == -1).ToArray();

        if(missingNum.Length > 0)
        {
            return missingNum[0];
        }
        else
        {
            if(minNum == 1)
                return maxNum + 1;
            else 
                return minNum - 1;
        }
    }
}
