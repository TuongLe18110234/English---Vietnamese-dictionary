using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PJ_Dictionary
{
    //Khai báo kiểu dữ liệu struct cho từ điển
    public struct aboutWord
    {
        public string word;
        public string pronunciation;
        public string wordType;
        public string mean;
    }

    //Khởi tạo class Node
    public class Node
    {
        public aboutWord data;
        public Node pLeft;
        public Node pRight;
        public int height;

        //Tạo một node mới với khóa là Key, không nhánh
        public Node(aboutWord key)
        {
            data = key;
            height = 1;
            pLeft = pRight = null;
        }
    }

    public class TREE
    {


        public Node root;

        //Khởi tạo cây rỗng
        public TREE()
        {
            root = null;
        }
        public int InsertNode(ref Node T, aboutWord key)
        {
            if (T != null)
            {
                if (String.Compare(key.word, T.data.word, true) == 0)
                {
                    return 0;
                }

                else if (String.Compare(key.word, T.data.word, true) < 0)
                    return InsertNode(ref T.pLeft, key);
                else
                    return InsertNode(ref T.pRight, key);
            }
            Node temp = new Node(key);
            if (temp == null)
                return -1;
            T = temp;
            return 1;
        }

        public void DiTimNodeTheMang(ref Node X, ref Node Y)
        {
            if (Y.pLeft != null)
                DiTimNodeTheMang(ref X, ref Y.pLeft);
            else
            {
                X.data = Y.data;
                X = Y;
                Y = Y.pRight;
            }
        }

        public void DeleteNode(ref Node node, string key)
        {
            if (node == null)
                return;
            else
            {
                if (String.Compare(key, node.data.word, true) < 0)
                    DeleteNode(ref node.pLeft, key);
                else if (String.Compare(key, node.data.word, true) > 0)
                    DeleteNode(ref node.pRight, key);
                else
                {
                    Node X = node;
                    if (node.pLeft == null)
                        node = node.pRight;
                    else if (node.pRight == null)
                        node = node.pLeft;
                    else
                    {
                        DiTimNodeTheMang(ref X, ref node.pRight);
                    }
                    X = null;
                }
            }
        }

        public Node Search(Node node, string key)
        {
            Node p = node;
            while (p != null)
            {
                if (string.Compare(key, p.data.word) == 0)
                    return p;
                else if (string.Compare(key, p.data.word) < 0)
                    p = p.pLeft;
                else
                    p = p.pRight;
            }
            return null;
        }


        //Xuất các từ
        public void duyet_NLR(Node node1, StreamWriter wr)
        {
            if (node1 == null) return;

            wr.WriteLine(node1.data.word);
            wr.WriteLine(node1.data.pronunciation);
            wr.WriteLine(node1.data.wordType);
            wr.WriteLine(node1.data.mean);

            duyet_NLR(node1.pLeft, wr);
            duyet_NLR(node1.pRight, wr);
        }

        public void writeToFile(Node node)
        {
            StreamWriter wr = new StreamWriter(@"duLieuTuDien.txt", false, Encoding.UTF8);
            duyet_NLR(node, wr);
            wr.Close();
        }

        public void loadCombobox(Node node1,ref List<string> danhSachTu)
        {
            if (node1 == null)
                return;

            loadCombobox(node1.pLeft,ref danhSachTu);
            danhSachTu.Add(node1.data.word);
            loadCombobox(node1.pRight,ref danhSachTu);
        }
        //---------------------Cay AVL------------------------------//

        //A utility function to get
        // the height of the tree  
        int height(Node N)
        {
            if (N == null)
                return 0;

            return N.height;
        }

        // A utility function to get 
        // maximum of two integers  
        int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // A utility function to right  
        // rotate subtree rooted with y  
        // See the diagram given above.  
        Node rightRotate(Node y)
        {
            Node x = y.pLeft;
            Node T2 = x.pRight;

            // Perform rotation  
            x.pRight = y;
            y.pLeft = T2;

            // Update heights  
            y.height = max(height(y.pLeft),
                        height(y.pRight)) + 1;
            x.height = max(height(x.pLeft),
                        height(x.pRight)) + 1;

            // Return new root  
            return x;
        }

        // A utility function to left 
        // rotate subtree rooted with x  
        // See the diagram given above.  
        Node leftRotate(Node x)
        {
            Node y = x.pRight;
            Node T2 = y.pLeft;

            // Perform rotation  
            y.pLeft = x;
            x.pRight = T2;

            // Update heights  
            x.height = max(height(x.pLeft),
                        height(x.pRight)) + 1;
            y.height = max(height(y.pLeft),
                        height(y.pRight)) + 1;

            // Return new root  
            return y;
        }

        // Get Balance factor of node N  
        int getBalance(Node N)
        {
            if (N == null)
                return 0;

            return height(N.pLeft) - height(N.pRight);
        }

        public Node insert(Node node, aboutWord key)
        {

            /* 1. Perform the normal BST insertion */
            if (node == null)
                return (new Node(key));

            if (String.Compare(key.word, node.data.word, true) < 0)
                node.pLeft = insert(node.pLeft, key);
            else if (String.Compare(key.word, node.data.word, true) > 0)
                node.pRight = insert(node.pRight, key);
            else // Duplicate keys not allowed  
                return node;

            /* 2. Update height of this ancestor node */
            node.height = 1 + max(height(node.pLeft),
                                height(node.pRight));

            /* 3. Get the balance factor of this ancestor  
                node to check whether this node became  
                unbalanced */
            int balance = getBalance(node);

            // If this node becomes unbalanced, then there  
            // are 4 cases Left Left Case  
            if (balance > 1 && string.Compare(key.word, node.pLeft.data.word) < 0)
                return rightRotate(node);

            // Right Right Case  
            if (balance < -1 && string.Compare(key.word, node.pRight.data.word) > 0)
                return leftRotate(node);

            // Left Right Case  
            if (balance > 1 && string.Compare(key.word, node.pLeft.data.word) > 0)
            {
                node.pLeft = leftRotate(node.pLeft);
                return rightRotate(node);
            }

            // Right Left Case  
            if (balance < -1 && string.Compare(key.word, node.pRight.data.word) < 0)
            {
                node.pRight = rightRotate(node.pRight);
                return leftRotate(node);
            }

            /* return the (unchanged) node pointer */
            return node;
        }
    }
}
