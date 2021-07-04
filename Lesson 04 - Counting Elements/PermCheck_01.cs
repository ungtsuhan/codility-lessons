///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 4 July 2021
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
        int numToSearch = 1;
        
        foreach(var num in A)
        {
            if(num == numToSearch)
            {
                numToSearch++;
            }
            else if(num > numToSearch)
            {
                // missing num
                return 0;
            }
            else
            {
                // repeated num
                return 0;
            }
        }
        return 1;
    }
}
