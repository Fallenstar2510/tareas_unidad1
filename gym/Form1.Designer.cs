namespace gym
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
            label2 = new Label();
            resultado = new TextBox();
            button1 = new Button();
            num = new TextBox();
            num1 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AccessibleName = "cuadro1";
            label2.AutoSize = true;
            label2.Location = new Point(265, 120);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // resultado
            // 
            resultado.Location = new Point(342, 221);
            resultado.Name = "resultado";
            resultado.Size = new Size(125, 27);
            resultado.TabIndex = 2;
            resultado.TextChanged += resultado_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(356, 275);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // num
            // 
            num.Location = new Point(147, 184);
            num.Name = "num";
            num.Size = new Size(125, 27);
            num.TabIndex = 4;
            num.TextChanged += num_TextChanged;
            // 
            // num1
            // 
            num1.Location = new Point(537, 184);
            num1.Name = "num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(num1);
            Controls.Add(num);
            Controls.Add(button1);
            Controls.Add(resultado);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox resultado;
        private Button button1;
        private TextBox num;
        private TextBox num1;
    }
}
