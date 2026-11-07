/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head == null){
            return null;
        }

        Dictionary<Node, Node> result = new Dictionary<Node, Node>();
        Node curr = head;

        while(curr != null){
            result.Add(curr, new Node(curr.val));
            curr = curr.next;
        }
        
        curr = head;
        while(curr != null){
            result[curr].next = curr.next == null ? null : result[curr.next];
            result[curr].random = curr.random == null ? null : result[curr.random];

            curr = curr.next;
        }

        return result[head];
    }
}
