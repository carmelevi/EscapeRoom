
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_undo = new System.Windows.Forms.Button();
            this.b_commit = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.journal_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.miniQR_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // b_undo
            // 
            this.b_undo.Enabled = false;
            this.b_undo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_undo.Image = ((System.Drawing.Image)(resources.GetObject("b_undo.Image")));
            this.b_undo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_undo.Location = new System.Drawing.Point(890, 104);
            this.b_undo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_undo.Name = "b_undo";
            this.b_undo.Size = new System.Drawing.Size(90, 40);
            this.b_undo.TabIndex = 0;
            this.b_undo.Text = "UNDO";
            this.b_undo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_undo.UseVisualStyleBackColor = true;
            this.b_undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // b_commit
            // 
            this.b_commit.Enabled = false;
            this.b_commit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_commit.Location = new System.Drawing.Point(834, 47);
            this.b_commit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_commit.Name = "b_commit";
            this.b_commit.Size = new System.Drawing.Size(90, 40);
            this.b_commit.TabIndex = 1;
            this.b_commit.Text = "COMMIT";
            this.b_commit.UseVisualStyleBackColor = true;
            this.b_commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // b_clear
            // 
            this.b_clear.Enabled = false;
            this.b_clear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_clear.Location = new System.Drawing.Point(950, 47);
            this.b_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(90, 40);
            this.b_clear.TabIndex = 2;
            this.b_clear.Text = "CLEAR";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // journal_panel
            // 
            this.journal_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.journal_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.journal_panel.Location = new System.Drawing.Point(834, 158);
            this.journal_panel.Margin = new System.Windows.Forms.Padding(0);
            this.journal_panel.Name = "journal_panel";
            this.journal_panel.Size = new System.Drawing.Size(206, 636);
            this.journal_panel.TabIndex = 5;
            // 
            // miniQR_panel
            // 
            this.miniQR_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.miniQR_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.miniQR_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.miniQR_panel.Location = new System.Drawing.Point(1054, 158);
            this.miniQR_panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.miniQR_panel.Name = "miniQR_panel";
            this.miniQR_panel.Size = new System.Drawing.Size(106, 636);
            this.miniQR_panel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cyber;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 820);
            this.Controls.Add(this.miniQR_panel);
            this.Controls.Add(this.journal_panel);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.b_commit);
            this.Controls.Add(this.b_undo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QR Code";
            this.ResumeLayout(false);

        }

        #endregion

        private Button b_undo;
        private Button b_commit;
        private Button b_clear;
        private FlowLayoutPanel journal_panel;
        private FlowLayoutPanel miniQR_panel;


        
    }
    
}

