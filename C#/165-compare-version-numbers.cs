public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] version1Sections = version1.Split('.');
        string[] version2Sections = version2.Split('.');

        int[] version1SectionsInts = new int[version1Sections.Length];
        int[] version2SectionsInts = new int[version2Sections.Length];

        for(int x = 0; x < version1Sections.Length; x++){
            version1SectionsInts[x] = int.Parse(version1Sections[x]);
        }
        for(int y = 0; y < version2Sections.Length; y++){
            version2SectionsInts[y] = int.Parse(version2Sections[y]);
        }


        int max = Math.Max(version1SectionsInts.Length,version2SectionsInts.Length);
        for(int x = 0; x < max; x++){
            if(x < version1SectionsInts.Length && x < version2SectionsInts.Length){
            
                if(version1SectionsInts[x] < version2SectionsInts[x]){
                    return -1;
                }else if(version1SectionsInts[x] > version2SectionsInts[x]){
                    return 1;
                }


            }else if(x >= version1SectionsInts.Length && version2SectionsInts[x] != 0){
                return -1;
            }else if(x >= version2SectionsInts.Length && version1SectionsInts[x] != 0){
                return 1;
            }

        }

        return 0;
    }
}