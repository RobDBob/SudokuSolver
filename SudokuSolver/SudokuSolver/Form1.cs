using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        public List<TextBox> Box1;
        public List<TextBox> Box2;
        public List<TextBox> Box3;
        public List<TextBox> Box4;
        public List<TextBox> Box5;
        public List<TextBox> Box6;
        public List<TextBox> Box7;
        public List<TextBox> Box8;
        public List<TextBox> Box9;

        public List<TextBox> Row1;
        public List<TextBox> Row2;
        public List<TextBox> Row3;
        public List<TextBox> Row4;
        public List<TextBox> Row5;
        public List<TextBox> Row6;
        public List<TextBox> Row7;
        public List<TextBox> Row8;
        public List<TextBox> Row9;

        public List<TextBox> Col1;
        public List<TextBox> Col2;
        public List<TextBox> Col3;
        public List<TextBox> Col4;
        public List<TextBox> Col5;
        public List<TextBox> Col6;
        public List<TextBox> Col7;
        public List<TextBox> Col8;
        public List<TextBox> Col9;

        public List<List<TextBox>> AllBoxes;
        public List<List<TextBox>> AllRows;
        public List<List<TextBox>> AllCols;
        public List<List<TextBox>> AllSets;

        public bool flagPainted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Box1 = new List<TextBox> { textBox1_1, textBox1_2, textBox1_3, textBox1_4, textBox1_5, textBox1_6, textBox1_7, textBox1_8, textBox1_9 };
            Box2 = new List<TextBox> { textBox2_1, textBox2_2, textBox2_3, textBox2_4, textBox2_5, textBox2_6, textBox2_7, textBox2_8, textBox2_9 };
            Box3 = new List<TextBox> { textBox3_1, textBox3_2, textBox3_3, textBox3_4, textBox3_5, textBox3_6, textBox3_7, textBox3_8, textBox3_9 };
            Box4 = new List<TextBox> { textBox4_1, textBox4_2, textBox4_3, textBox4_4, textBox4_5, textBox4_6, textBox4_7, textBox4_8, textBox4_9 };
            Box5 = new List<TextBox> { textBox5_1, textBox5_2, textBox5_3, textBox5_4, textBox5_5, textBox5_6, textBox5_7, textBox5_8, textBox5_9 };
            Box6 = new List<TextBox> { textBox6_1, textBox6_2, textBox6_3, textBox6_4, textBox6_5, textBox6_6, textBox6_7, textBox6_8, textBox6_9 };
            Box7 = new List<TextBox> { textBox7_1, textBox7_2, textBox7_3, textBox7_4, textBox7_5, textBox7_6, textBox7_7, textBox7_8, textBox7_9 };
            Box8 = new List<TextBox> { textBox8_1, textBox8_2, textBox8_3, textBox8_4, textBox8_5, textBox8_6, textBox8_7, textBox8_8, textBox8_9 };
            Box9 = new List<TextBox> { textBox9_1, textBox9_2, textBox9_3, textBox9_4, textBox9_5, textBox9_6, textBox9_7, textBox9_8, textBox9_9 };

            Row1 = new List<TextBox> { textBox1_1, textBox1_2, textBox1_3, textBox2_1, textBox2_2, textBox2_3, textBox3_1, textBox3_2, textBox3_3 };
            Row2 = new List<TextBox> { textBox1_4, textBox1_5, textBox1_6, textBox2_4, textBox2_5, textBox2_6, textBox3_4, textBox3_5, textBox3_6 };
            Row3 = new List<TextBox> { textBox1_7, textBox1_8, textBox1_9, textBox2_7, textBox2_8, textBox2_9, textBox3_7, textBox3_8, textBox3_9 };
            Row4 = new List<TextBox> { textBox4_1, textBox4_2, textBox4_3, textBox5_1, textBox5_2, textBox5_3, textBox6_1, textBox6_2, textBox6_3 };
            Row5 = new List<TextBox> { textBox4_4, textBox4_5, textBox4_6, textBox5_4, textBox5_5, textBox5_6, textBox6_4, textBox6_5, textBox6_6 };
            Row6 = new List<TextBox> { textBox4_7, textBox4_8, textBox4_9, textBox5_7, textBox5_8, textBox5_9, textBox6_7, textBox6_8, textBox6_9 };
            Row7 = new List<TextBox> { textBox7_1, textBox7_2, textBox7_3, textBox8_1, textBox8_2, textBox8_3, textBox9_1, textBox9_2, textBox9_3 };
            Row8 = new List<TextBox> { textBox7_4, textBox7_5, textBox7_6, textBox8_4, textBox8_5, textBox8_6, textBox9_4, textBox9_5, textBox9_6 };
            Row9 = new List<TextBox> { textBox7_7, textBox7_8, textBox7_9, textBox8_7, textBox8_8, textBox8_9, textBox9_7, textBox9_8, textBox9_9 };

            Col1 = new List<TextBox> { textBox1_1, textBox1_4, textBox1_7, textBox4_1, textBox4_4, textBox4_7, textBox7_1, textBox7_4, textBox7_7 };
            Col2 = new List<TextBox> { textBox1_2, textBox1_5, textBox1_8, textBox4_2, textBox4_5, textBox4_8, textBox7_2, textBox7_5, textBox7_8 };
            Col3 = new List<TextBox> { textBox1_3, textBox1_6, textBox1_9, textBox4_3, textBox4_6, textBox4_9, textBox7_3, textBox7_6, textBox7_9 };
            Col4 = new List<TextBox> { textBox2_1, textBox2_4, textBox2_7, textBox5_1, textBox5_4, textBox5_7, textBox8_1, textBox8_4, textBox8_7 };
            Col5 = new List<TextBox> { textBox2_2, textBox2_5, textBox2_8, textBox5_2, textBox5_5, textBox5_8, textBox8_2, textBox8_5, textBox8_8 };
            Col6 = new List<TextBox> { textBox2_3, textBox2_6, textBox2_9, textBox5_3, textBox5_6, textBox5_9, textBox8_3, textBox8_6, textBox8_9 };
            Col7 = new List<TextBox> { textBox3_1, textBox3_4, textBox3_7, textBox6_1, textBox6_4, textBox6_7, textBox9_1, textBox9_4, textBox9_7 };
            Col8 = new List<TextBox> { textBox3_2, textBox3_5, textBox3_8, textBox6_2, textBox6_5, textBox6_8, textBox9_2, textBox9_5, textBox9_8 };
            Col9 = new List<TextBox> { textBox3_3, textBox3_6, textBox3_9, textBox6_3, textBox6_6, textBox6_9, textBox9_3, textBox9_6, textBox9_9 };

            AllBoxes = new List<List<TextBox>> { Box1, Box2, Box3, Box4, Box5, Box6, Box7, Box8, Box9 };
            AllRows = new List<List<TextBox>> { Row1, Row2, Row3, Row4, Row5, Row6, Row7, Row8, Row9 };
            AllCols = new List<List<TextBox>> { Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9 };

            AllSets = new List<List<TextBox>>
            {
                Box1, Box2, Box3, Box4, Box5, Box6, Box7, Box8, Box9,
                Row1, Row2, Row3, Row4, Row5, Row6, Row7, Row8, Row9,
                Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9
            };
        }

        private void SolveSudoku_Click(object sender, EventArgs e)
        {
            var sudokuValidator = new Validator();
            sudokuValidator.ValidateSet(AllBoxes);
        }

        private void Test_Click(object sender, EventArgs e)
        {
            var subsetToPaint = AllSets.First();
            
            if(flagPainted)
            {
                ColorSubset.ApplyBackgroundColorToGivenSet(subsetToPaint, Color.White);
                AllSets.Remove(AllSets.First());
                flagPainted = false;
            }
            else
            {
                ColorSubset.ApplyBackgroundColorToGivenSet(subsetToPaint, Color.Black);
                flagPainted = true;
            }
        }
    }
}

