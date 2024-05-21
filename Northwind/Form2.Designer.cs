namespace Northwind
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(36, 38);
            button1.Name = "button1";
            button1.Size = new Size(126, 42);
            button1.TabIndex = 0;
            button1.Text = "Categories";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 113);
            button2.Name = "button2";
            button2.Size = new Size(126, 42);
            button2.TabIndex = 1;
            button2.Text = "Customers";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(36, 258);
            button3.Name = "button3";
            button3.Size = new Size(126, 42);
            button3.TabIndex = 2;
            button3.Text = "Orders";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(36, 320);
            button4.Name = "button4";
            button4.Size = new Size(126, 42);
            button4.TabIndex = 3;
            button4.Text = "Products";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(36, 186);
            button5.Name = "button5";
            button5.Size = new Size(126, 42);
            button5.TabIndex = 4;
            button5.Text = "Employees";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(211, 38);
            button6.Name = "button6";
            button6.Size = new Size(126, 42);
            button6.TabIndex = 5;
            button6.Text = "Region";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(211, 113);
            button7.Name = "button7";
            button7.Size = new Size(126, 42);
            button7.TabIndex = 6;
            button7.Text = "Shippers";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(211, 186);
            button8.Name = "button8";
            button8.Size = new Size(126, 42);
            button8.TabIndex = 7;
            button8.Text = "Supliers";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(211, 258);
            button9.Name = "button9";
            button9.Size = new Size(126, 42);
            button9.TabIndex = 8;
            button9.Text = "Territories";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(255, 395);
            button10.Name = "button10";
            button10.Size = new Size(82, 33);
            button10.TabIndex = 9;
            button10.Text = "Regresar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 440);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Northwind";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}