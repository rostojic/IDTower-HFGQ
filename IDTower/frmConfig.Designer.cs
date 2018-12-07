namespace IDTower
{
    partial class frmConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSKULabelTemplate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SKULabelContent Template";
            // 
            // txtSKULabelTemplate
            // 
            this.txtSKULabelTemplate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSKULabelTemplate.Location = new System.Drawing.Point(36, 52);
            this.txtSKULabelTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKULabelTemplate.Name = "txtSKULabelTemplate";
            this.txtSKULabelTemplate.Size = new System.Drawing.Size(398, 22);
            this.txtSKULabelTemplate.TabIndex = 2;
            this.txtSKULabelTemplate.Text = "01UUUUUUUUUUUUUU310000_PW_13DDMMYY21___SERIAL___|";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSKULabelTemplate);
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSKULabelTemplate;
    }
}