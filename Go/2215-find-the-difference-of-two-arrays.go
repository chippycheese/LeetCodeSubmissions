func findDifference(nums1 []int, nums2 []int) [][]int {
    var fa []int
    var sa []int
    var ta [][]int

    //first array
    for _, v := range nums1 {
        if !contains(nums2, v) && !contains(fa, v){
            fa = append(fa,v)
        }
    }

    //second array
    for _, v := range nums2 {
        if !contains(nums1, v) && !contains(sa, v){
            sa = append(sa,v)
        }
    }

    ta = append(ta,fa)
    ta = append(ta,sa)
    return ta
}

func contains(slice []int, element int) bool {
    for _, v := range slice {
        if v == element {
            return true
        }
    }
    return false
}