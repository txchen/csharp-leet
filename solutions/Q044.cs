public class Solution {
    public bool IsMatch(string s, string p) {
        // this can be non recursive
        int iIndex = 0;
        int pIndex = 0;
        int starIndex = -1;
        while (iIndex < s.Length)
        {
            if (pIndex >= p.Length) // no pattern left
            {
                if (starIndex == -1)
                {
                    return false; // previously no star, then no match
                }
                // start from previous star again, move input one step forward
                int moveBack = pIndex - starIndex;
                pIndex = pIndex - moveBack + 1;
                iIndex = iIndex - moveBack + 2; // iIndex move one step forward, and try again
                continue;
            }
            switch (p[pIndex])
            {
                case '*':
                    // handle continous star
                    while (pIndex < p.Length && p[pIndex] == '*')
                    {
                        pIndex += 1;
                    }
                    starIndex = pIndex - 1;
                    break;
                case '?':
                    iIndex++;
                    pIndex++;
                    break;
                default:
                    if (p[pIndex] == s[iIndex])
                    {
                        iIndex++;
                        pIndex++;
                    }
                    else // not matching, back to previous star position
                    {
                        if (starIndex == -1)
                        {
                            return false;
                        }
                        int moveBack = pIndex - starIndex;
                        pIndex = pIndex - moveBack + 1;
                        iIndex = iIndex - moveBack + 2; // iIndex move one step forward, and try again
                    }
                    break;
            }
        }
        // remaining pattern can only be stars
        return p.Substring(pIndex).Trim('*').Length == 0;
    }
}
