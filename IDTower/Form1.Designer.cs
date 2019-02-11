namespace IDTower
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
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResultPAID = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt310K = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartSerail = new System.Windows.Forms.TextBox();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPAIDpart3 = new System.Windows.Forms.TextBox();
            this.txtPAIDpart2 = new System.Windows.Forms.TextBox();
            this.txtPAIDpart1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.Color.Aqua;
            this.txtSKU.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.Location = new System.Drawing.Point(31, 54);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(127, 22);
            this.txtSKU.TabIndex = 2;
            this.txtSKU.Text = "12200001613669";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SKU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate Output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.LightGreen;
            this.txtResult.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtResult.Location = new System.Drawing.Point(31, 427);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(1022, 351);
            this.txtResult.TabIndex = 11;
            this.txtResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtResult_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(31, 394);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Result SKULabelContent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(31, 314);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Result PAID 1 && 2";
            // 
            // txtResultPAID
            // 
            this.txtResultPAID.BackColor = System.Drawing.Color.LightGreen;
            this.txtResultPAID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultPAID.Location = new System.Drawing.Point(31, 349);
            this.txtResultPAID.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultPAID.Name = "txtResultPAID";
            this.txtResultPAID.ReadOnly = true;
            this.txtResultPAID.Size = new System.Drawing.Size(1022, 22);
            this.txtResultPAID.TabIndex = 27;
            this.txtResultPAID.Text = "370000004      ";
            this.txtResultPAID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtResultPAID_MouseClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(850, 253);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(187, 20);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Text pattern locked?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 231);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "PAID part 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "PAID part 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(31, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "PAID pattern";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefix.Location = new System.Drawing.Point(587, 153);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.ReadOnly = true;
            this.txtPrefix.Size = new System.Drawing.Size(47, 22);
            this.txtPrefix.TabIndex = 47;
            this.txtPrefix.Text = "01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Prefix";
            // 
            // txt310K
            // 
            this.txt310K.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt310K.Location = new System.Drawing.Point(668, 153);
            this.txt310K.Margin = new System.Windows.Forms.Padding(4);
            this.txt310K.Name = "txt310K";
            this.txt310K.ReadOnly = true;
            this.txt310K.Size = new System.Drawing.Size(62, 22);
            this.txt310K.TabIndex = 49;
            this.txt310K.Text = "310000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(665, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "310K";
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(764, 153);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW.Name = "txtPW";
            this.txtPW.ReadOnly = true;
            this.txtPW.Size = new System.Drawing.Size(47, 22);
            this.txtPW.TabIndex = 38;
            this.txtPW.Text = "2180";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(850, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 20);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Increase Start serial?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "PW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(941, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Start Serial";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(845, 153);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(65, 22);
            this.txtDate.TabIndex = 40;
            this.txtDate.Text = "130319";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Occurences?";
            // 
            // txtStartSerail
            // 
            this.txtStartSerail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartSerail.Location = new System.Drawing.Point(944, 153);
            this.txtStartSerail.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartSerail.Name = "txtStartSerail";
            this.txtStartSerail.ReadOnly = true;
            this.txtStartSerail.Size = new System.Drawing.Size(104, 22);
            this.txtStartSerail.TabIndex = 44;
            this.txtStartSerail.Text = "107400404549";
            // 
            // numTotal
            // 
            this.numTotal.Location = new System.Drawing.Point(178, 54);
            this.numTotal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.Size = new System.Drawing.Size(87, 22);
            this.numTotal.TabIndex = 42;
            this.numTotal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(587, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "SKULabelContent Pattern";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 131);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "PAID part 1";
            // 
            // txtPAIDpart3
            // 
            this.txtPAIDpart3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::IDTower.Properties.Settings.Default, "paid3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPAIDpart3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAIDpart3.Location = new System.Drawing.Point(31, 253);
            this.txtPAIDpart3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAIDpart3.Name = "txtPAIDpart3";
            this.txtPAIDpart3.ReadOnly = true;
            this.txtPAIDpart3.Size = new System.Drawing.Size(409, 22);
            this.txtPAIDpart3.TabIndex = 36;
            this.txtPAIDpart3.Text = global::IDTower.Properties.Settings.Default.paid3;
            // 
            // txtPAIDpart2
            // 
            this.txtPAIDpart2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::IDTower.Properties.Settings.Default, "paid2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPAIDpart2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAIDpart2.Location = new System.Drawing.Point(31, 203);
            this.txtPAIDpart2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAIDpart2.Name = "txtPAIDpart2";
            this.txtPAIDpart2.ReadOnly = true;
            this.txtPAIDpart2.Size = new System.Drawing.Size(409, 22);
            this.txtPAIDpart2.TabIndex = 34;
            this.txtPAIDpart2.Text = global::IDTower.Properties.Settings.Default.paid2;
            // 
            // txtPAIDpart1
            // 
            this.txtPAIDpart1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::IDTower.Properties.Settings.Default, "paid1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPAIDpart1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAIDpart1.Location = new System.Drawing.Point(31, 153);
            this.txtPAIDpart1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAIDpart1.Name = "txtPAIDpart1";
            this.txtPAIDpart1.ReadOnly = true;
            this.txtPAIDpart1.Size = new System.Drawing.Size(409, 22);
            this.txtPAIDpart1.TabIndex = 32;
            this.txtPAIDpart1.Text = global::IDTower.Properties.Settings.Default.paid1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 791);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt310K);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStartSerail);
            this.Controls.Add(this.numTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPAIDpart3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtResultPAID);
            this.Controls.Add(this.txtPAIDpart2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPAIDpart1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSKU);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Dragutinu, kad se popne na ID Tower :)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtResultPAID;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPAIDpart3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPAIDpart2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPAIDpart1;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt310K;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartSerail;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

