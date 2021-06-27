////////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 28 July 2021
// Total Score  : 100%
// Task Score   : 100%
// Correctness  : 100%
// Performance  : Not assessed
//	
///////////////////////////////////////////////////////////////////////////////////

using System;

class Solution {
    
    public int[] solution(int[] A, int K) {
        
        // ensure input array is not empty
        if(A.Length == 0)
            return A;

        // eliminate repeated rotation
        int rotationCount = (K >= A.Length) ? K%A.Length: K;

        // no rotation required
        if(rotationCount == 0)
            return A;

        // initialize array after rotation
        int[] rotatedA = new int[A.Length];

        // Copy right side of the source array and put at front
        Array.Copy(A, A.Length - rotationCount, rotatedA, 0, rotationCount);
        // Copy front side of the source array and put at back
        Array.Copy(A, 0, rotatedA, rotationCount, A.Length - rotationCount);

        return rotatedA;
    }
}