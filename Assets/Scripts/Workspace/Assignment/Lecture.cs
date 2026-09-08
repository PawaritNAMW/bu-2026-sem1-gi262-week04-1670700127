using UnityEngine;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> list = new List<string>();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Node 1");
            linkedList.AddLast("Node 2");
            linkedList.AddFirst("Node 0");
            PrintLinkList(linkedList);

            LinkedListNode<string> firstNode = linkedList.First;
            Debug.Log("first: " + firstNode.Value);
            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("Last: " + lastNode.Value);
            LinkedListNode<string> node1 = linkedList.Find("Node 1");
            Debug.Log("node: " + node1.Value);
            Debug.Log(node1.Previous.Value);
            Debug.Log(node1.Next.Value);
            if (firstNode.Previous == null)
            {
                Debug.Log("firstNode.Previous is null");
            }
            if (lastNode.Next == null)
            {
                Debug.Log("lastNode.Next is null");
            }

            linkedList.AddAfter(node1, "Node 1.5");
            linkedList.AddBefore(node1, "Node 0.5");
            PrintLinkList(linkedList);

            linkedList.RemoveFirst();
            PrintLinkList(linkedList);
            linkedList.Remove("Node 2");
            PrintLinkList(linkedList);
            linkedList.Clear();
            PrintLinkList(linkedList);
        }

        void PrintLinkList(LinkedList<string> linkedList)
        {
            Debug.Log("------------linkedList----------");
            foreach (string s in linkedList)
            {
                Debug.Log(s);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary[3] = "Cherry";

            int keytocheck = 1;
            bool hasKey = dictionary.ContainsKey(keytocheck);
            Debug.Log($"has key {keytocheck}:{hasKey}");
            if (hasKey)
            {
                Debug.Log(dictionary[keytocheck]);
            }

            foreach (int k in dictionary.Keys)
            {
                Debug.Log(k);
            }
            foreach (int s in dictionary.Keys)
            {
                Debug.Log(s);
            }

            dictionary.Remove(1);
            foreach (int s in dictionary.Keys)
            {
                Debug.Log(s);
            }

            dictionary.Clear();
            foreach (int s in dictionary.Keys)
            {
                Debug.Log(s);
            }
        }

        #endregion
    }
}
