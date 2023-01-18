namespace Taschenrechner
{
    partial class Calculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RechtsRest = new System.Windows.Forms.TextBox();
            this.LinksRest = new System.Windows.Forms.TextBox();
            this.ResultRestB = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RechtsRest);
            this.panel1.Controls.Add(this.LinksRest);
            this.panel1.Controls.Add(this.ResultRestB);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.multiply);
            this.panel1.Controls.Add(this.subtract);
            this.panel1.Controls.Add(this.add);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(479, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 4);
            this.label2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(291, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 4);
            this.label1.TabIndex = 32;
            // 
            // RechtsRest
            // 
            this.RechtsRest.Location = new System.Drawing.Point(229, 152);
            this.RechtsRest.Name = "RechtsRest";
            this.RechtsRest.Size = new System.Drawing.Size(45, 22);
            this.RechtsRest.TabIndex = 30;
            this.RechtsRest.Text = "0";
            // 
            // LinksRest
            // 
            this.LinksRest.Location = new System.Drawing.Point(11, 151);
            this.LinksRest.Name = "LinksRest";
            this.LinksRest.Size = new System.Drawing.Size(45, 22);
            this.LinksRest.TabIndex = 0;
            this.LinksRest.Text = "0";
            // 
            // ResultRestB
            // 
            this.ResultRestB.AutoSize = true;
            this.ResultRestB.Location = new System.Drawing.Point(447, 159);
            this.ResultRestB.Name = "ResultRestB";
            this.ResultRestB.Size = new System.Drawing.Size(14, 16);
            this.ResultRestB.TabIndex = 27;
            this.ResultRestB.Text = "0";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(143, 259);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 100;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClick);
            // 
            // divide
            // 
            this.divide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divide.Location = new System.Drawing.Point(162, 205);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(30, 30);
            this.divide.TabIndex = 90;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divideButton);
            // 
            // multiply
            // 
            this.multiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiply.Location = new System.Drawing.Point(162, 162);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(30, 30);
            this.multiply.TabIndex = 80;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiplicationButton);
            // 
            // subtract
            // 
            this.subtract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subtract.Location = new System.Drawing.Point(162, 125);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(30, 30);
            this.subtract.TabIndex = 70;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtractionButton);
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add.Location = new System.Drawing.Point(162, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(30, 30);
            this.add.TabIndex = 60;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.additionButton);
            // 
            // strich
            // 
            this.strich.BackColor = System.Drawing.SystemColors.Desktop;
            this.strich.Location = new System.Drawing.Point(73, 170);
            this.strich.Name = "strich";
            this.strich.Size = new System.Drawing.Size(57, 4);
            this.strich.TabIndex = 17;
            // 
            // ResultFullB
            // 
            this.ResultFullB.AutoSize = true;
            this.ResultFullB.Location = new System.Drawing.Point(447, 233);
            this.ResultFullB.Name = "ResultFullB";
            this.ResultFullB.Size = new System.Drawing.Size(110, 16);
            this.ResultFullB.TabIndex = 10;
            this.ResultFullB.Text = "Ganzes Ergebnis";
            // 
            // SecondOben
            // 
            this.SecondOben.Location = new System.Drawing.Point(303, 129);
            this.SecondOben.Name = "SecondOben";
            this.SecondOben.Size = new System.Drawing.Size(45, 22);
            this.SecondOben.TabIndex = 40;
            this.SecondOben.Text = "0";
            this.SecondOben.TextChanged += new System.EventHandler(this.TextChangeor);
            // 
            // SecondUnten
            // 
            this.SecondUnten.Location = new System.Drawing.Point(303, 184);
            this.SecondUnten.Name = "SecondUnten";
            this.SecondUnten.Size = new System.Drawing.Size(45, 22);
            this.SecondUnten.TabIndex = 50;
            this.SecondUnten.Text = "0";
            this.SecondUnten.TextChanged += new System.EventHandler(this.TextChangeUr);
            // 
            // FirstUnten
            // 
            this.FirstUnten.Location = new System.Drawing.Point(76, 186);
            this.FirstUnten.Name = "FirstUnten";
            this.FirstUnten.Size = new System.Drawing.Size(45, 22);
            this.FirstUnten.TabIndex = 20;
            this.FirstUnten.Text = "0";
            this.FirstUnten.TextChanged += new System.EventHandler(this.TextChangeul);
            // 
            // firstOben
            // 
            this.firstOben.Location = new System.Drawing.Point(76, 134);
            this.firstOben.Name = "firstOben";
            this.firstOben.Size = new System.Drawing.Size(45, 22);
            this.firstOben.TabIndex = 10;
            this.firstOben.Text = "0";
            this.firstOben.TextChanged += new System.EventHandler(this.TextChangeol);
            // 
            // ResultObenB
            // 
            this.ResultObenB.AutoSize = true;
            this.ResultObenB.Location = new System.Drawing.Point(500, 132);
            this.ResultObenB.Name = "ResultObenB";
            this.ResultObenB.Size = new System.Drawing.Size(14, 16);
            this.ResultObenB.TabIndex = 5;
            this.ResultObenB.Text = "0";
            // 
            // ResultUntenB
            // 
            this.ResultUntenB.AutoSize = true;
            this.ResultUntenB.Location = new System.Drawing.Point(500, 188);
            this.ResultUntenB.Name = "ResultUntenB";
            this.ResultUntenB.Size = new System.Drawing.Size(14, 16);
            this.ResultUntenB.TabIndex = 4;
            this.ResultUntenB.Text = "0";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 375);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
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
        private System.Windows.Forms.Label strich;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label ResultRestB;
        private System.Windows.Forms.TextBox RechtsRest;
        private System.Windows.Forms.TextBox LinksRest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

