/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * func guess(num int) int;
 */

func guessNumber(n int) int {
    myGuess := n / 2
    halfing := myGuess
    off := guess(myGuess)
    for(off != 0){
        halfing = halfing / 2
        if(halfing == 0){
            halfing = 1
        }
        if(off > 0){
            myGuess += halfing
        }else if(off < 0){
            myGuess -= halfing
        }
        off = guess(myGuess)
    }
    return myGuess
}