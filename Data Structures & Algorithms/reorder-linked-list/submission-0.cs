/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        if(head == null || head.next == null){
            return;
        }

        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode nua_sau = slow.next;
        slow.next = null;

        ListNode curr_sau = nua_sau;;
        ListNode prev = null;
        while(curr_sau != null){
            ListNode nextNodeSau = curr_sau.next;
            curr_sau.next = prev;
            prev = curr_sau;
            curr_sau = nextNodeSau;
        }

        nua_sau = prev;
        ListNode nua_dau = head;

        ListNode p1 = nua_dau;
        ListNode p2 = nua_sau;

        while(p2 != null){
            ListNode temp1 = p1.next;
            ListNode temp2 = p2.next;

            p1.next = p2;
            p2.next = temp1;

            p1 = temp1;
            p2 = temp2;
        }
    }
}
