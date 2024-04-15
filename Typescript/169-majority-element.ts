function majorityElement(nums: number[]): number {
    var mElement = nums[0];
    var counter = 1;
    for(var cnt = 1; cnt <nums.length; cnt++){
        if(mElement == nums[cnt]){
            counter++;
        }else{
            counter--;
            if(counter == 0){
                counter = 1;
                mElement = nums[cnt];
            }
        }
    }
    return mElement;
};