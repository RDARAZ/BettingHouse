using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifoLifo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("pierwszy w kolejce");
            myQueue.Enqueue("drugi w kolejce");
            myQueue.Enqueue("trzeci w kolejce");
            myQueue.Enqueue("ostatni w kolejce");
            string takeALook = myQueue.Peek();
            string getFirst = myQueue.Dequeue();
            string getNext = myQueue.Dequeue();
            int howMany = myQueue.Count;
            myQueue.Clear();
            MessageBox.Show("Peek() zwróciło: " + takeALook + "\n"
                + "Pierwsze Dequeue() zwróciło: " + getFirst + "\n"
                + "Drugie Dequeue() zwróciło: " + getNext + "\n"
                + "Count przed Clear() było równe " + howMany + "\n"
                + "Count po Clear() jest równe " + myQueue.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("pierwszy na stosie");
            myStack.Push("drugi na stosie");
            myStack.Push("trzeci na stosie");
            myStack.Push("ostatni na stosie");
            string takeALook = myStack.Peek();
            string getFirst = myStack.Pop();
            string getNext = myStack.Pop();
            int howMany = myStack.Count;
            myStack.Clear();
            MessageBox.Show("Peek() zwróciło: " + takeALook + "\n"
                + "Pierwsze Pop() zwróciło: " + getFirst + "\n"
                + "Drugie Pop() zwróciło: " + getNext + "\n"
                + "Count przed Clear() było równe " + howMany + "\n"
                + "Count po Clear() jest równe " + myStack.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("pierwszy w rzędzie");
            myStack.Push("drugi w rzędzie");
            myStack.Push("trzeci w rzędzie");
            myStack.Push("ostatni w rzędzie");

            Queue<string> myQueue = new Queue<string>(myStack);
            List<string> myList = new List<string>(myQueue);
            Stack<string> anotherStack = new Stack<string>(myList);
            MessageBox.Show("myQueue ma " + myQueue.Count + " elementy\n"
                + "myList ma " + myList.Count + " elementy\n"
                + "anotherStack ma " + anotherStack.Count + " elementy\n");
        }
    }
}
