
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 820);
            this.Name = "Form1";
            this.Text = "QR Code";
            this.ResumeLayout(false);

            string background = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string bg_filename = System.IO.Path.Combine(background, "cyber.png");
            Image image = new Bitmap(bg_filename);
            Image bg_image = new Bitmap(image, 1200, 820);


            this.BackgroundImage = bg_image;

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

            rep = initial_rep;

            ToolTip tt = new ToolTip();

            for (int x = 1; x <= 25; x++)
            {
                Button newButton = new Button();
                newButton.Location = new System.Drawing.Point(20, 50 + (x-1) * 30);
                newButton.Size = new System.Drawing.Size(23, 30);
                newButton.BackColor = System.Drawing.Color.White;
                
                newButton.Font = new Font(newButton.Font.FontFamily, 6);
                newButton.TabStop = false;
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                newButton.Text = x.ToString();
                this.Controls.Add(newButton);

            }

            char letter = 'A'; 
            for (int y = 0; y < 25; y++)
            {
                Button newButton = new Button();
                newButton.Location = new System.Drawing.Point(50 + y * 30, 20);
                newButton.Size = new System.Drawing.Size(30, 23);
                newButton.BackColor = System.Drawing.Color.White;

                newButton.Font = new Font(newButton.Font.FontFamily, 6);
                newButton.TabStop = false;
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                newButton.Text = letter.ToString();
                this.Controls.Add(newButton);
                letter++;
            }
            
            // Init buttons
            for (int i = 0; i < 25; i++)
            {
                char c = 'A';

                for (int j = 0; j < 25; j++)
                {
                    Button newButton = new Button();
                    newButton.Location = new System.Drawing.Point(50 + j *30, 50 + i*30);
                    newButton.Size = new System.Drawing.Size(30, 30);
                    
                    tt.SetToolTip(newButton, c.ToString() + (i + 1));
                    
                    //TODO : Decide how to show Text
                    newButton.Text = c.ToString() + (i + 1);
                    newButton.MouseEnter += b_MouseEnter;
                    newButton.MouseLeave += b_MouseLeave;

                    newButton.Font = new Font(newButton.Font.FontFamily, 6);
                    newButton.TabStop = false;
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.FlatAppearance.BorderSize = 0;
                    if (rep[i, j] == 1)
                    {
                        newButton.BackColor = System.Drawing.Color.Black;
                        newButton.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        newButton.BackColor = System.Drawing.Color.White;
                        newButton.ForeColor = System.Drawing.Color.White;
                    }
                    newButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                    newButton.Click += b_Click;

                    
                    this.Controls.Add(newButton);
                    QRmat[i,j] = newButton;

                    c++;
                }
            }

            // Undo Button
            b_undo = new Button();
            b_undo.Text = "UNDO";
            b_undo.Location = new System.Drawing.Point(950, 150);
            b_undo.Size = new System.Drawing.Size(90, 40);
            
            string dir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string filename = System.IO.Path.Combine(dir, "Undo.ico");
            b_undo.Image = Image.FromFile(filename);
            b_undo.ImageAlign = ContentAlignment.MiddleLeft;
            b_undo.TextAlign = ContentAlignment.MiddleRight;
            b_undo.Font = new Font("Cambria", 12, FontStyle.Bold);
            
            b_undo.Enabled = false;
            b_undo.Click += undo_Click;
            
            this.Controls.Add(b_undo);

            button_stack = new Stack();
            label_list = new List<string>();

            // Label
            label = new Label();
            label.Location = new System.Drawing.Point(900, 200);
            label.Height = 500;
            label.Width = 200;
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
            label.Font = new Font("Georgia", 16);
            update_label();
            this.Controls.Add(label);
        }

        #endregion

        private int[,] rep;
        private Button[,] QRmat = new Button[25,25];
        private Stack button_stack;
        private List<string> label_list;
        
        private Button b_undo;
        private Label label;
                    
        private void update_label()
        {
            string txt = "";
            foreach (string l in label_list)
            {
                txt = txt + " " + l;
            }
            label.Text = txt;
        }

        void b_Click(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == System.Drawing.Color.White)
            {
                b.BackColor = System.Drawing.Color.Black;
            }
             else
            {
                b.BackColor = System.Drawing.Color.White;
            }

            button_stack.Push(b);
            b_undo.Enabled = true;

            label_list.Add(b.Text);
            update_label();

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
            Button b = (Button)button_stack.Pop();
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

            if (button_stack.Count == 0)
            {
                b_undo.Enabled = false;
            }

            label_list.RemoveAt(label_list.Count-1);
            update_label();            
        }


    }

}

