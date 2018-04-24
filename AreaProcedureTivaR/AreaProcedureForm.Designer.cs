namespace AreaProcedureTivaR
{
    partial class frmAreaProcedure
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLengthBox = new System.Windows.Forms.TextBox();
            this.txtWidthBox = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(39, 40);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(202, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter the length and width of a rectangle.";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(39, 106);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(39, 148);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // txtLengthBox
            // 
            this.txtLengthBox.Location = new System.Drawing.Point(111, 106);
            this.txtLengthBox.Name = "txtLengthBox";
            this.txtLengthBox.Size = new System.Drawing.Size(100, 20);
            this.txtLengthBox.TabIndex = 3;
            // 
            // txtWidthBox
            // 
            this.txtWidthBox.Location = new System.Drawing.Point(111, 148);
            this.txtWidthBox.Name = "txtWidthBox";
            this.txtWidthBox.Size = new System.Drawing.Size(100, 20);
            this.txtWidthBox.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(89, 200);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Area";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmAreaProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 278);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidthBox);
            this.Controls.Add(this.txtLengthBox);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmAreaProcedure";
            this.Text = "Area Procedure by Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLengthBox;
        private System.Windows.Forms.TextBox txtWidthBox;
        private System.Windows.Forms.Button btnCalculate;
    }
}

