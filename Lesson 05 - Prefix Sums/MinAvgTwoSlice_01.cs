///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 10 July 2021
// Total Score  : 60%
// Task Score   : 60%
// Correctness  : 100%
// Performance  : 20%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;

class Solution {
    public int solution(int[] A) {
        
        var maxSliceLen = A.Length;
        var minAvgStartPos = 0;
        double minAvg = (A[0]+A[1])/2;

        for(int sliceLen = 2; sliceLen < maxSliceLen; sliceLen++)
        {
            for(var startPos = 0; (startPos + sliceLen - 1) < A.Length; i++)
            {
                int sum = 0;
                for(var j = 0; j < sliceLen; j++)
                {
                    sum += A[startPos+j];
                }
                double avg = (double)sum/sliceLen;
                if(avg < minAvg)
                {
                    minAvg = avg; 
                    minAvgStartPos = startPos;
                }
                else if(avg == minAvg && startPos < minAvgStartPos)
                {
                    minAvgStartPos = startPos;
                }
            }
        }
        return minAvgStartPos;
    }
}