using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BubbleSorting
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreateRandom.Visible = true;
            btnBubbleSorting.Visible = false;
            btnClear.Visible = false;
        }

        //------------------------- Button Create Random Click --------------------------

        private void btnCreateRandom_Click(object sender, EventArgs e)
        {
            btnCreateRandom.Visible = false;
            btnBubbleSorting.Visible = true;
            btnClear.Visible = false;

            //Generate radom numbers
            Random rnd = new Random();
            for (int i =0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }

            //Display result
            string strRnd = "Random Array: ";
            for (int i=0; i < (numbers.Length-1);i++)
            {
                strRnd += numbers[i].ToString() + ",";
            }
            strRnd += numbers[numbers.Length - 1].ToString();
            lblRandom.Text = strRnd;
        }


        //----------------------------------- SWAP () --------------------------------

        private bool swap(ref int top, ref int bottom)
        {
            int temp;
            if (top <= bottom)
                return false;

            temp = top;
            top = bottom;
            bottom = temp;
            return true; 
        }


        //------------------------Bubble Sorting Button Click-----------------------------

        private void btnBubbleSorting_Click(object sender, EventArgs e)
        {
            btnCreateRandom.Visible = false;
            btnBubbleSorting.Visible = false;
            btnClear.Visible = true;

            //Bubble Sort 

            Array.Sort(numbers);

            //bool inorder = false;
            //while (!inorder)
            //{
            //    inorder = true;
            //    for (int i =0; i < (numbers.Length-1); i++)
            //    {
            //        if (swap(ref numbers[i], ref numbers[i + 1]))
            //            inorder = false;
            //    }
            //}

            //Display rresults
            string strSorted = "Sorted Array: ";
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                strSorted += numbers[i].ToString() + ",";
            }
            strSorted += numbers[numbers.Length - 1].ToString();
            lblSorted.Text = strSorted;
        }

        //---------------------- Clear Button Click ---------------------------------

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnCreateRandom.Visible = true;
            btnBubbleSorting.Visible = false;
            btnClear.Visible = false;

            lblRandom.Text = "Random Array: ";
            lblSorted.Text = "Sorted Array: ";
        }
    }
}
