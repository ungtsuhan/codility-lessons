///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 4 July 2021
// Total Score  : 81%
// Task Score   : 81%
// Correctness  : 100%
// Performance  : 60%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;
using System.Linq;

class Solution {
    public int solution(int X, int[] A) {
        
        var numToSearch = Enumerable.Range(1, X).ToList();
        
        for(var i=0; i < A.Length; i++)
        {
            var index = numToSearch.IndexOf(A[i]);
            if(index != -1)
            {
                numToSearch.RemoveAt(index);
            }

            if(numToSearch.Count() == 0)
            {
                return i;
            }
        }
        return -1;
    }
}