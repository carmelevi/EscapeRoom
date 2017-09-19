using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Button[,] QRmat = new Button[25, 25];
        private Stack<List<Button>> button_stack = new Stack<List<Button>>();

        private List<Label> label_list = new List<Label>();
        private List<PictureBox> miniQR_list = new List<PictureBox>();

        private int chosen_count;

        public Form1()
        {
            InitializeComponent();
            initQRmatrix();

            chosen_count = 0;
        }

        private void initQRmatrix()
        {
            int[,] initial_rep =   {   {1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1},
                                       {1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1},
                                       {1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
                                       {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1},
                                       {1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
                                       {1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1},
                                       {1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1},
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                                       {1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0},
                                       {0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0},
                                       {1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1},
                                       {0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1},
                                       {0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1},
                                       {1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0},
                                       {1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0},
                                       {1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1},
                                       {1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0},
                                       {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0},
                                       {1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1},
                                       {1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1},
                                       {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1},
                                       {1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0},
                                       {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1},
                                       {1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1},
                                       {1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1}    };


            for (int x = 1; x <= 25; x++)
            {

                Label newButton = new Label();
                newButton.Location = new System.Drawing.Point(20, 50 + (x - 1) * 30);
                newButton.Size = new System.Drawing.Size(23, 30);
                newButton.BackColor = System.Drawing.Color.White;

                newButton.Font = new Font(newButton.Font.FontFamily, 6);
                newButton.TextAlign = ContentAlignment.MiddleCenter;
                newButton.TabStop = false;
                newButton.FlatStyle = FlatStyle.Flat;

                newButton.Text = x.ToString();
                this.Controls.Add(newButton);
            }

            char letter = 'A';
            for (int y = 0; y < 25; y++)
            {
                Label newButton = new Label();
                newButton.Location = new System.Drawing.Point(50 + y * 30, 20);
                newButton.Size = new System.Drawing.Size(30, 23);
                newButton.BackColor = System.Drawing.Color.White;

                newButton.Font = new Font(newButton.Font.FontFamily, 6);
                newButton.TextAlign = ContentAlignment.MiddleCenter;
                newButton.TabStop = false;
                newButton.FlatStyle = FlatStyle.Flat;

                newButton.Text = letter.ToString();
                this.Controls.Add(newButton);
                letter++;
            }

            ToolTip tt = new ToolTip();

            for (int i = 0; i < 25; i++)
            {
                char c = 'A';

                for (int j = 0; j < 25; j++)
                {
                    Button newButton = new Button();
                    newButton.Location = new System.Drawing.Point(50 + j * 30, 50 + i * 30);
                    newButton.Size = new System.Drawing.Size(30, 30);

                    tt.SetToolTip(newButton, c.ToString() + (i + 1));

                    //TODO : Decide how to show Text
                    newButton.Text = c.ToString() + (i + 1);
                    newButton.MouseEnter += b_MouseEnter;
                    newButton.MouseLeave += b_MouseLeave;

                    newButton.Font = new Font(newButton.Font.FontFamily, 5);
                    newButton.TabStop = false;
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                    if (initial_rep[i, j] == 1)
                    {
                        newButton.BackColor = System.Drawing.Color.Black;
                        newButton.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        newButton.BackColor = System.Drawing.Color.White;
                        newButton.ForeColor = System.Drawing.Color.White;
                    }

                    newButton.Click += b_Click;


                    this.Controls.Add(newButton);
                    QRmat[i, j] = newButton;

                    c++;
                }
            }
        }

        void b_Click(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;

            if (b.FlatAppearance.BorderColor == Color.Red)
            {
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                chosen_count--;

            }
            else
            {
                b.FlatAppearance.BorderColor = Color.Red;
                b.FlatAppearance.BorderSize = 2;
                chosen_count++;
            }

            if (chosen_count == 0)
            {
                b_commit.Enabled = false;
                b_clear.Enabled = false;
            }
            else
            {
                b_commit.Enabled = true;
                b_clear.Enabled = true;
            }
        }

        void b_MouseEnter(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = System.Drawing.Color.Gray;
        }

        void b_MouseLeave(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = System.Drawing.Color.Gray;

            if (b.BackColor == System.Drawing.Color.Black)
            {
                b.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                b.ForeColor = System.Drawing.Color.White;
            }
        }

        void undo_Click(object sender, System.EventArgs e)
        {

            List<Button> commit_list = (List<Button>)button_stack.Pop();

            foreach (Button b in commit_list)
            {

                if (b.BackColor == System.Drawing.Color.White)
                {
                    b.BackColor = System.Drawing.Color.Black;
                    b.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    b.BackColor = System.Drawing.Color.White;
                    b.ForeColor = System.Drawing.Color.White;
                }
            }

            if (button_stack.Count == 0)
            {
                b_undo.Enabled = false;
            }        
            
            if (button_stack.Count == 0)
            {
                b_undo.Enabled = false;
            }

            removeFromLog();

            miniQR_list.RemoveAt(miniQR_list.Count - 1);
            drawMiniQR();

        }

        void commit_Click(object sender, System.EventArgs e)
        {
            List<Button> chosenButtons = new List<Button>();
            String commit_log = "";
            
            PictureBox miniQR = new PictureBox();
            miniQR.Size = new Size(100, 100);
            miniQR.BorderStyle = BorderStyle.None;

            Bitmap flag = new Bitmap(100, 100);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.White, 0, 0, 100, 100);
            
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Button current = QRmat[i, j];
                    if (current.FlatAppearance.BorderColor == Color.Red)
                    {
                        chosenButtons.Add(current);
                        current.FlatAppearance.BorderSize = 0;
                        current.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                        switchColor(current);

                        commit_log += " - " + current.Text;

                        flagGraphics.FillRectangle(Brushes.Black, j*4, i*4, 4, 4);
                    }
                }
            }

            miniQR.Image = flag;
            miniQR_list.Add(miniQR);
            drawMiniQR();

            commit_log = commit_log.Substring(2);
            addToLog(commit_log);

            button_stack.Push(chosenButtons);
                      

            chosen_count = 0;
            b_commit.Enabled = false;
            b_clear.Enabled = false;
            b_undo.Enabled = true;
            
        }
        
        void clear_Click(object sender, System.EventArgs e)
        {

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Button current = QRmat[i, j];
                    if (current.FlatAppearance.BorderColor == Color.Red)
                    {
                        current.FlatAppearance.BorderSize = 0;
                        current.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);

                    }
                }
            }

            chosen_count = 0;
            b_commit.Enabled = false;
            b_clear.Enabled = false;
        }

        void addToLog(String log)
        {
            Label lbl = new Label();

            lbl.BackColor = System.Drawing.Color.White;
            lbl.Font = new System.Drawing.Font("Georgia", 10F);
            lbl.ForeColor = System.Drawing.Color.Black;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.Text = log;
            lbl.Width = 200;
            lbl.Height = 100;
            lbl.TabIndex = 3;
            lbl.Margin = new System.Windows.Forms.Padding(3);

            label_list.Add(lbl);
            drawLog();

        }

        void removeFromLog()
        {
            label_list.RemoveAt(label_list.Count - 1);
            drawLog();
        }

        void drawLog()
        {
            journal_panel.Controls.Clear();
            List<Label> label_list_cpy = new List<Label>(label_list);
            label_list_cpy.Reverse();

            foreach (Label l in label_list_cpy)
            {
                this.journal_panel.Controls.Add(l);
            }
        }

        void drawMiniQR()
        {
            miniQR_panel.Controls.Clear();
            List<PictureBox> miniQR_list_cpy = new List<PictureBox>(miniQR_list);
            miniQR_list_cpy.Reverse();

            foreach (PictureBox p in miniQR_list_cpy)
            {
                this.miniQR_panel.Controls.Add(p);
            }
        }

        void switchColor(Button b)
        {
            if (b.BackColor == System.Drawing.Color.White)
            {
                b.BackColor = System.Drawing.Color.Black;
                b.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                b.BackColor = System.Drawing.Color.White;
                b.ForeColor = System.Drawing.Color.White;
            }
        }

    }

}