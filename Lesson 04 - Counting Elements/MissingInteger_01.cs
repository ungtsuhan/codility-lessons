///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 3 July 2021
// Total Score  : 0%
// Task Score   : 0%
// Correctness  : 0%
// Performance  : 0%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;

class Solution {
    public int solution(int[] A)
    {
        Array.Sort(A);
        
        int numToSearch = 1;
        
        foreach(var num in A)
        {
            
            if(num > 0)
            {
                // numToSearch is missing
                if(num > numToSearch)
                {
                    return numToSearch;
                }
                // numToSearch is found
                else if(num == numToSearch)
                {
                    numToSearch++;
                }
            }
        }
        return numToSearch;
    }
}