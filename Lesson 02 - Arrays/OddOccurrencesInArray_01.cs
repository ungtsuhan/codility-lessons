///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 28 June 2021
// Total Score  : 66%
// Task Score   : 66%
// Correctness  : 100%
// Performance  : 25%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

class Solution {
    
    public int solution(int[] A) {
        
        List<int> oddOccurrences = new List<int>();

        foreach(var num in A)
        {
            int indexOfNumInOddOccurrences = oddOccurrences.IndexOf(num);
            
            if(indexOfNumInOddOccurrences != -1)
            {
                // Appear second time, cancel off the odd occurrences
                oddOccurrences.RemoveAt(indexOfNumInOddOccurrences);
            }
            else
            {
                // Appear first time, add value to odd occurrences list
                oddOccurrences.Add(num);
            }
        }

        if(oddOccurrences.Count > 0)
            return oddOccurrences[0];
        else
            return 0;
    }
}