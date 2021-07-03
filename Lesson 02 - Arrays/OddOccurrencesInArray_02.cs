///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 28 June 2021
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
        var oddOccurrenceLists = A.GroupBy(x => x)
            .Select(n => new
            {
                num = n.Key,
                count = n.Count()
            })
            .Where(u => (u.count %2) != 0)
            .ToList();

        if(oddOccurrenceLists.Count > 0)
            return oddOccurrenceLists[0].num;
        else
            return 0;
    }
}   