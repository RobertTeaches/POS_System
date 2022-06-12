namespace Burger_Display
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.orderingPanel = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.remove_Button = new System.Windows.Forms.Button();
            this.finish_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(216, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(326, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome to Burger King POS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderingPanel
            // 
            this.orderingPanel.Controls.Add(this.listBox2);
            this.orderingPanel.Controls.Add(this.listBox1);
            this.orderingPanel.Controls.Add(this.remove_Button);
            this.orderingPanel.Controls.Add(this.finish_Button);
            this.orderingPanel.Controls.Add(this.add_Button);
            this.orderingPanel.Controls.Add(this.label2);
            this.orderingPanel.Controls.Add(this.label1);
            this.orderingPanel.Location = new System.Drawing.Point(280, 71);
            this.orderingPanel.Name = "orderingPanel";
            this.orderingPanel.Size = new System.Drawing.Size(492, 361);
            this.orderingPanel.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(334, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 229);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(16, 35);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 214);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // remove_Button
            // 
            this.remove_Button.BackColor = System.Drawing.Color.Tomato;
            this.remove_Button.Enabled = false;
            this.remove_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_Button.Location = new System.Drawing.Point(364, 290);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(90, 28);
            this.remove_Button.TabIndex = 7;
            this.remove_Button.Text = "Renove";
            this.remove_Button.UseVisualStyleBackColor = false;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // finish_Button
            // 
            this.finish_Button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.finish_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finish_Button.Location = new System.Drawing.Point(219, 307);
            this.finish_Button.Name = "finish_Button";
            this.finish_Button.Size = new System.Drawing.Size(121, 46);
            this.finish_Button.TabIndex = 6;
            this.finish_Button.Text = "Finish Order";
            this.finish_Button.UseVisualStyleBackColor = true;
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(49, 280);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(121, 46);
            this.add_Button.TabIndex = 5;
            this.add_Button.Text = "Add to Order";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(340, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 444);
            this.Controls.Add(this.orderingPanel);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.orderingPanel.ResumeLayout(false);
            this.orderingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Panel orderingPanel;
        private Button finish_Button;
        private Button add_Button;
        private Label label2;
        private Label label1;
        private Button remove_Button;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}