public class RecentCounter {

    int counter = 0;
    LinkedList<int> calls;

    public RecentCounter() {
        calls = new LinkedList<int>();
    }
    
    public int Ping(int t) {
        calls.AddLast(t);
        counter ++;
        while(calls.First != null && calls.First.Value < t - 3000 ){
            counter --;
            calls.RemoveFirst();
        }
        return counter;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */