///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 6 July 2021
// Total Score  : 62%
// Task Score   : 62%
// Correctness  : 100%
// Performance  : 0%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;

enum impactFactor {
    A = 1,
    C = 2,
    G = 3,
    T = 4
}

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        
        int[] minImpactFactor = new int[P.Length];
        
        for(int i = 0; i < P.Length; i++)
        {
            foreach (string character in Enum.GetNames(typeof(impactFactor)))
            {
                if(S.Substring(P[i], Q[i] - P[i] + 1).Contains(character))
                {
                    impactFactor impFactorVal;
                    if(Enum.TryParse<impactFactor>(character, out impFactorVal))
                    {
                        minImpactFactor[i] = (int)impFactorVal;
                        break;
                    }     
                }
            }
        }
        
        return minImpactFactor;
    }
}
