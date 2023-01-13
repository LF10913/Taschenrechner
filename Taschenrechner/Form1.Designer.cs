namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.strich = new System.Windows.Forms.Label();
            this.ResultFullB = new System.Windows.Forms.Label();
            this.SecondOben = new System.Windows.Forms.TextBox();
            this.SecondUnten = new System.Windows.Forms.TextBox();
            this.FirstUnten = new System.Windows.Forms.TextBox();
            this.firstOben = new System.Windows.Forms.TextBox();
            this.ResultObenB = new System.Windows.Forms.Label();
            this.ResultUntenB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.multiply);
            this.panel1.Controls.Add(this.subtract);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.strich);
            this.panel1.Controls.Add(this.ResultFullB);
            this.panel1.Controls.Add(this.SecondOben);
            this.panel1.Controls.Add(this.SecondUnten);
            this.panel1.Controls.Add(this.FirstUnten);
            this.panel1.Controls.Add(this.firstOben);
            this.panel1.Controls.Add(this.ResultObenB);
            this.panel1.Controls.Add(this.ResultUntenB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 375);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(197, 246);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClick);
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divide.Location = new System.Drawing.Point(220, 202);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(21, 26);
            this.divide.TabIndex = 23;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divideButton);
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiply.Location = new System.Drawing.Point(220, 170);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(22, 26);
            this.multiply.TabIndex = 22;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiplicationButton);
            // 
            // subtract
            // 
            this.subtract.AutoSize = true;
            this.subtract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subtract.Location = new System.Drawing.Point(220, 138);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(21, 26);
            this.subtract.TabIndex = 21;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtractionButton);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add.Location = new System.Drawing.Point(217, 106);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(24, 26);
            this.add.TabIndex = 20;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.additionButton);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(447, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 4);
            this.label3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(278, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 4);
            this.label2.TabIndex = 18;
            // 
            // strich
            // 
            this.strich.BackColor = System.Drawing.SystemColors.Desktop;
            this.strich.Location = new System.Drawing.Point(68, 170);
            this.strich.Name = "strich";
            this.strich.Size = new System.Drawing.Size(125, 4);
            this.strich.TabIndex = 17;
            // 
            // ResultFullB
            // 
            this.ResultFullB.AutoSize = true;
            this.ResultFullB.Location = new System.Drawing.Point(470, 277);
            this.ResultFullB.Name = "ResultFullB";
            this.ResultFullB.Size = new System.Drawing.Size(13, 16);
            this.ResultFullB.TabIndex = 10;
            this.ResultFullB.Text = "x";
            
            // 
            // SecondOben
            // 
            this.SecondOben.Location = new System.Drawing.Point(294, 142);
            this.SecondOben.Name = "SecondOben";
            this.SecondOben.Size = new System.Drawing.Size(100, 22);
            this.SecondOben.TabIndex = 9;
            this.SecondOben.Text = "2";
            this.SecondOben.TextChanged += new System.EventHandler(this.TextChangeor);
            // 
            // SecondUnten
            // 
            this.SecondUnten.Location = new System.Drawing.Point(294, 188);
            this.SecondUnten.Name = "SecondUnten";
            this.SecondUnten.Size = new System.Drawing.Size(100, 22);
            this.SecondUnten.TabIndex = 8;
            this.SecondUnten.Text = "-3";
            this.SecondUnten.TextChanged += new System.EventHandler(this.TextChangeUr);
            // 
            // FirstUnten
            // 
            this.FirstUnten.Location = new System.Drawing.Point(81, 188);
            this.FirstUnten.Name = "FirstUnten";
            this.FirstUnten.Size = new System.Drawing.Size(100, 22);
            this.FirstUnten.TabIndex = 7;
            this.FirstUnten.Text = "7";
            this.FirstUnten.TextChanged += new System.EventHandler(this.TextChangeul);
            // 
            // firstOben
            // 
            this.firstOben.Location = new System.Drawing.Point(81, 142);
            this.firstOben.Name = "firstOben";
            this.firstOben.Size = new System.Drawing.Size(100, 22);
            this.firstOben.TabIndex = 6;
            this.firstOben.Text = "-3";
            this.firstOben.TextChanged += new System.EventHandler(this.TextChangeol);
            // 
            // ResultObenB
            // 
            this.ResultObenB.AutoSize = true;
            this.ResultObenB.Location = new System.Drawing.Point(470, 138);
            this.ResultObenB.Name = "ResultObenB";
            this.ResultObenB.Size = new System.Drawing.Size(13, 16);
            this.ResultObenB.TabIndex = 5;
            this.ResultObenB.Text = "x";
            // 
            // ResultUntenB
            // 
            this.ResultUntenB.AutoSize = true;
            this.ResultUntenB.Location = new System.Drawing.Point(470, 194);
            this.ResultUntenB.Name = "ResultUntenB";
            this.ResultUntenB.Size = new System.Drawing.Size(13, 16);
            this.ResultUntenB.TabIndex = 4;
            this.ResultUntenB.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 375);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ResultObenB;
        private System.Windows.Forms.Label ResultUntenB;
        private System.Windows.Forms.TextBox SecondOben;
        private System.Windows.Forms.TextBox SecondUnten;
        private System.Windows.Forms.TextBox FirstUnten;
        private System.Windows.Forms.TextBox firstOben;
        private System.Windows.Forms.Label ResultFullB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label strich;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clearButton;
    }
}

