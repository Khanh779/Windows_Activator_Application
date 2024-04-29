﻿namespace Windows_Activator_Application
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
            this.PN_Title = new System.Windows.Forms.Panel();
            this.cButton2 = new Windows_Activator_Application.Custom_Controls.CButton();
            this.cButton1 = new Windows_Activator_Application.Custom_Controls.CButton();
            this.LB_Form_Text = new System.Windows.Forms.Label();
            this.PB_Icon = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cButton4 = new Windows_Activator_Application.Custom_Controls.CButton();
            this.cButton3 = new Windows_Activator_Application.Custom_Controls.CButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cDragForm1 = new Windows_Activator_Application.Custom_Controls.CDragForm();
            this.cDragForm2 = new Windows_Activator_Application.Custom_Controls.CDragForm();
            this.cDragForm3 = new Windows_Activator_Application.Custom_Controls.CDragForm();
            this.PN_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Title
            // 
            this.PN_Title.BackColor = System.Drawing.Color.Transparent;
            this.PN_Title.Controls.Add(this.cButton2);
            this.PN_Title.Controls.Add(this.cButton1);
            this.PN_Title.Controls.Add(this.LB_Form_Text);
            this.PN_Title.Controls.Add(this.PB_Icon);
            this.PN_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Title.Location = new System.Drawing.Point(1, 1);
            this.PN_Title.Name = "PN_Title";
            this.PN_Title.Size = new System.Drawing.Size(461, 35);
            this.PN_Title.TabIndex = 0;
            // 
            // cButton2
            // 
            this.cButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton2.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton2.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton2.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton2.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton2.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton2.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton2.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cButton2.Location = new System.Drawing.Point(400, 2);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(30, 30);
            this.cButton2.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton2.TabIndex = 3;
            this.cButton2.Text = "0";
            this.cButton2.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton2.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton2.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton2_MouseClick);
            // 
            // cButton1
            // 
            this.cButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton1.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton1.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton1.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton1.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton1.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cButton1.Location = new System.Drawing.Point(434, 2);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(30, 30);
            this.cButton1.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton1.TabIndex = 1;
            this.cButton1.Text = "r";
            this.cButton1.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton1.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton1.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton1_MouseClick);
            // 
            // LB_Form_Text
            // 
            this.LB_Form_Text.AutoSize = true;
            this.LB_Form_Text.BackColor = System.Drawing.Color.Transparent;
            this.LB_Form_Text.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Form_Text.ForeColor = System.Drawing.Color.LightGray;
            this.LB_Form_Text.Location = new System.Drawing.Point(34, 10);
            this.LB_Form_Text.Name = "LB_Form_Text";
            this.LB_Form_Text.Size = new System.Drawing.Size(84, 17);
            this.LB_Form_Text.TabIndex = 1;
            this.LB_Form_Text.Text = "LB_Form_Text";
            // 
            // PB_Icon
            // 
            this.PB_Icon.Location = new System.Drawing.Point(8, 8);
            this.PB_Icon.Name = "PB_Icon";
            this.PB_Icon.Size = new System.Drawing.Size(20, 20);
            this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Icon.TabIndex = 2;
            this.PB_Icon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.cButton4);
            this.flowLayoutPanel1.Controls.Add(this.cButton3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 269);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 46);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // cButton4
            // 
            this.cButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton4.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.cButton4.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.cButton4.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cButton4.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cButton4.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cButton4.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton4.Location = new System.Drawing.Point(350, 3);
            this.cButton4.Name = "cButton4";
            this.cButton4.Size = new System.Drawing.Size(98, 31);
            this.cButton4.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton4.TabIndex = 5;
            this.cButton4.Text = "Close";
            this.cButton4.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton4.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton4.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton4_MouseClick);
            // 
            // cButton3
            // 
            this.cButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton3.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cButton3.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cButton3.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton3.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton3.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton3.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton3.Location = new System.Drawing.Point(246, 3);
            this.cButton3.Name = "cButton3";
            this.cButton3.Size = new System.Drawing.Size(98, 31);
            this.cButton3.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton3.TabIndex = 4;
            this.cButton3.Text = "Activate";
            this.cButton3.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton3.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton3.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton3_MouseClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.richTextBox1.Location = new System.Drawing.Point(20, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(422, 191);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // cDragForm1
            // 
            this.cDragForm1.Form = this;
            this.cDragForm1.MaximizeFullScreen = false;
            this.cDragForm1.SupportMaximize = false;
            this.cDragForm1.TargetControl = this.PN_Title;
            // 
            // cDragForm2
            // 
            this.cDragForm2.Form = this;
            this.cDragForm2.MaximizeFullScreen = false;
            this.cDragForm2.SupportMaximize = false;
            this.cDragForm2.TargetControl = this.LB_Form_Text;
            // 
            // cDragForm3
            // 
            this.cDragForm3.Form = this;
            this.cDragForm3.MaximizeFullScreen = false;
            this.cDragForm3.SupportMaximize = false;
            this.cDragForm3.TargetControl = this.PB_Icon;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(463, 316);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PN_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Activator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PN_Title.ResumeLayout(false);
            this.PN_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PN_Title;
        private System.Windows.Forms.Label LB_Form_Text;
        private System.Windows.Forms.PictureBox PB_Icon;
        private Custom_Controls.CButton cButton1;
        private Custom_Controls.CDragForm cDragForm1;
        private Custom_Controls.CDragForm cDragForm2;
        private Custom_Controls.CDragForm cDragForm3;
        private Custom_Controls.CButton cButton2;
        private Custom_Controls.CButton cButton3;
        private Custom_Controls.CButton cButton4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

