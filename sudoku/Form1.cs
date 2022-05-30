using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace sudoku
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            createCells();
            startNewGame();
            create_number();      
        }
        private string temp;
        private int X, Y;
        Cons[,] cells = new Cons[9, 9];

        //create stack for id_cell
        Stack id_cells = new Stack(1000);

        //create board
        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new Cons();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(65, 65);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 65, j * 65);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control: Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;
                    cells[i, j].Name = string.Format("{0},{1}",i,j);
                    // Assign key press event for each cells
                    cells[i, j].KeyPress += cell_keyPressed;
                    cells[i, j].Click +=  cell_click;
                    plnMap.Controls.Add(cells[i, j]);
                }
            }
        }
        private void cell_click(object sender, EventArgs e)
        {
            var cell = sender as Cons;
            if (cell.IsLocked)
                return;
            temp = cell.Name;
            
        }
        //create number board
        private void create_number()
        {
            for(int i =1; i<= 9; i++)
            {
                Button btn = new Button();
                btn.Name = string.Format("{0}",i);
                btn.Tag = string.Format("{0}",i);
                btn.Size = new Size(110, 100);
                btn.Text = string.Format("{0}", i);
                btn.ForeColor = Color.Black;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
                btn.Margin = new Padding(4, 4, 0, 4);
                btn.BackColor = Color.White;
                //set event on button
                pnlNumber.Controls.Add(btn);
                btn.Click += new EventHandler(btn_click);
                
            }
        }
        private void btn_click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (temp == null)
            {
                return;
            }
            else
            {
                X = int.Parse(temp.Substring(0, 1));
                Y = int.Parse(temp.Substring(2));
                cells[X, Y].Text = btn.Name;
                cells[X, Y].ForeColor = Color.Red;
                id_cells.Push(temp);
                writeFile();
            }
            
        }
            private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Cons;
            // Do nothing if the cell is locked
            if (cell.IsLocked)
                return;
            int value;
            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();
                cell.ForeColor = SystemColors.ControlDarkDark;

            }
        }
            


        private void startNewGame()
        {
            loadValues();
           
            var hintsCount = 0;
            if (Beginner.Checked)
                hintsCount = 45;
            else if (Intermediate.Checked)
                hintsCount = 30;
            else if (Adv.Checked)
                hintsCount = 15;

            showRandomValuesHints(hintsCount);
        }

       
        //hàm random
        Random random = new Random();
        private void showRandomValuesHints(int hintsCount)
        {
            // Show value in radom cells
            // The hints count is based on the level player choose
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                // Style the hint cells differently and
                // lock the cell so that player can't edit the value
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
               
            }
        }

        private void loadValues()
        {
            // Clear the values in each cells
            foreach (var cell in cells)
            {
               cell.Value = 0;
               cell.Clear();
            }

            // This method will be called recursively 
            // until it finds suitable values for each cells
            findValueForNextCell(0, -1);
        }
        private bool findValueForNextCell(int i, int j)
        {
            // Increment the i and j values to move to the next cell
            // and if the columsn ends move to the next row
            if (++j > 8)
            {
                j = 0;

                // Exit if the line ends
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Find a random and valid number for the cell and go to the next cell 
            // and check if it can be allocated with another random and valid number
            do
            {
                // If there is not numbers left in the list to try next, 
                // return to the previous cell and allocate it with a different number
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }
                // Take a random number from the numbers left in the list
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                // Remove the allocated value from the list
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));
            return true;
        }
        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Check all the cells in the specific block
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }
      
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            startNewGame();
            temp = null;
            s = 0;
            m = 0;
            h = 0;  
            if (Beginner.Checked == true || Intermediate.Checked == true || Adv.Checked== true)
            {
                btnCheck.Enabled = true;
                btnClear.Enabled = true;
                btnHelp.Enabled = true;
                btnDelete.Enabled = true;
                btnBack.Enabled = true;
                btnPause.Visible = true;
                btnTimer.Visible = false;
                btnResult.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("chọn Level trò chơi!");
            }   
           
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            var wrongCells = new List<Cons>();

            // Find all the wrong inputs
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            // Check if the inputs are wrong or the player wins 
            if (wrongCells.Any())
            {
                // Highlight the wrong inputs 
                wrongCells.ForEach(x => x.ForeColor = Color.BlueViolet);
                MessageBox.Show("Rất tiếc bạn đã thua!");
            }
            else
            {
                btnTimer.Visible = true;
                btnPause.Visible = false;
                timer1.Stop();
                MessageBox.Show("Chúc mừng! bạn đã thắng "+ time.Text);
               


            }
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                // Clear the cell only if it is not locked
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            showrandomHelp(1);
        }
        private void showrandomHelp(int hintsCount) 
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.MediumVioletRed;
                cells[rX, rY].IsLocked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPause.Visible = false;
            btnTimer.Visible = true;
            btnCheck.Enabled = false;
            btnClear.Enabled = false;
            btnHelp.Enabled = false;
            btnDelete.Enabled = false;
            btnBack.Enabled = false;
            btnResult.Enabled = false;

        }
        //setting time
        int h, m, s;

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnTimer.Visible = true;
            btnPause.Visible = false;
            timer1.Stop();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(temp == null)
            {
                return;
            }
            else
            {
                X = int.Parse(temp.Substring(0, 1));
                Y = int.Parse(temp.Substring(2));
                cells[X, Y].Text = "";
            }     
        }
        private string temp2;
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(id_cells.Count == 0)
            {
                return;
            }       
            else
            {
                temp2 = id_cells.Pop().ToString();
                X = int.Parse(temp2.Substring(0, 1));
                Y = int.Parse(temp2.Substring(2));
                cells[X, Y].Text = "";         
            }
            
        }


        private void Result(int hintsCount)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].IsLocked = true;
            }
        }


        private void btnResult_Click(object sender, EventArgs e)
        {
            Result(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = null;
            s = 0;
            m = 0;
            h = 0;
           
                btnCheck.Enabled = true;
                btnClear.Enabled = true;
                btnHelp.Enabled = true;
                btnDelete.Enabled = true;
                btnBack.Enabled = true;
                btnPause.Visible = true;
                btnTimer.Visible = false;
                btnResult.Enabled = true;
                timer1.Start();
            readFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void writeFile() {
            StreamWriter oFile = new StreamWriter("d:\\data.txt", false, Encoding.Unicode);

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {

                    if (cells[c, r].Text == "")
                        oFile.Write("0");   
                    else
                        oFile.Write(cells[c, r].Text);
                }


            }

            oFile.Close();
        }

        private void readFile()
        {
            StreamReader rFile = new StreamReader("d:\\data.txt");
            String temp = rFile.ReadToEnd();
            var temp2 = temp.ToList();
            Console.WriteLine(temp2);


            for (int r = 0; r < 9; r++)
                for (int c = 0; c < 9; c++)
                {
                    if (temp2[(r * 9 + c)].ToString() == "0")
                        cells[c, r].Text = "";
                    else
                        cells[c, r].Text = temp2[(r * 9 + c)].ToString();
                    cells[c, r].ForeColor = Color.Black;
                }

            rFile.Close();
        }

        private void btnTimer_Click_1(object sender, EventArgs e)
        {
            btnPause.Visible = true;
            btnTimer.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if(m == 60)
            {
                m = 0;
                h += 1;
            }
            time.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
