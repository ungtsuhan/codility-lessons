///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 27 July 2021
// Total Score  : 100%
// Task Score   : 100%
// Correctness  : 100%
// Performance  : Not assessed
//	
///////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

class Solution {
    
    public int solution(int N) {
        List<int> binary = integerToBinary(N);
        return getMaxBinaryGap(binary);
    }

    // Method which convert integer to binary in format of List of integer (0 or 1)
    private List<int> integerToBinary(int N)
    {
        List<int> binary = new List<int>();
        for(var i = 0; N > 0; i++)
        {
            binary.Add(N%2);
            N = N/2;
        }
        return binary;
    }

    // Method to find max binary gap count
    private int getMaxBinaryGap(List<int> binary)
    {
        int maxBinaryGap = 0;
        int currentGap = 0;
        bool isGapStart = false;

        foreach(var b in binary)
        {
            if(!isGapStart)
            {
                if(b == 1)
                {
                    isGapStart = true;
                }
            }
            else
            {
                if(b == 0)
                {
                    currentGap++;
                }   
                else if(b == 1)
                {
                    if(currentGap > 0)
                    {
                        if(currentGap > maxBinaryGap)
                        {
                            maxBinaryGap = currentGap;
                        }
                        currentGap = 0;
                    }
                }
            }
        }
        return maxBinaryGap;
    }
}