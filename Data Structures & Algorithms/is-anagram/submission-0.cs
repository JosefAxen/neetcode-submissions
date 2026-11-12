public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] schar = s.ToCharArray();
        Array.Sort(schar);

        char[] tchar = t.ToCharArray();
        Array.Sort(tchar);
        
        
        if(new string(schar) == new string(tchar)) return true;

        return false;
    }
}
