namespace BubbleSorting
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
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblSorted = new System.Windows.Forms.Label();
            this.btnCreateRandom = new System.Windows.Forms.Button();
            this.btnBubbleSorting = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.Location = new System.Drawing.Point(37, 26);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(94, 13);
            this.lblRandom.TabIndex = 0;
            this.lblRandom.Text = "Random Array :";
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorted.Location = new System.Drawing.Point(40, 73);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(85, 13);
            this.lblSorted.TabIndex = 1;
            this.lblSorted.Text = "Sorted Array :";
            // 
            // btnCreateRandom
            // 
            this.btnCreateRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRandom.Location = new System.Drawing.Point(156, 164);
            this.btnCreateRandom.Name = "btnCreateRandom";
            this.btnCreateRandom.Size = new System.Drawing.Size(116, 36);
            this.btnCreateRandom.TabIndex = 2;
            this.btnCreateRandom.Text = "Create Random";
            this.btnCreateRandom.UseVisualStyleBackColor = true;
            this.btnCreateRandom.Click += new System.EventHandler(this.btnCreateRandom_Click);
            // 
            // btnBubbleSorting
            // 
            this.btnBubbleSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubbleSorting.Location = new System.Drawing.Point(300, 164);
            this.btnBubbleSorting.Name = "btnBubbleSorting";
            this.btnBubbleSorting.Size = new System.Drawing.Size(101, 36);
            this.btnBubbleSorting.TabIndex = 2;
            this.btnBubbleSorting.Text = "Bubble Sorting";
            this.btnBubbleSorting.UseVisualStyleBackColor = true;
            this.btnBubbleSorting.Click += new System.EventHandler(this.btnBubbleSorting_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(438, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBubbleSorting);
            this.Controls.Add(this.btnCreateRandom);
            this.Controls.Add(this.lblSorted);
            this.Controls.Add(this.lblRandom);
            this.Name = "Form1";
            this.Text = "Bubble Sort Created By Vladislavas Petrokas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.Button btnCreateRandom;
        private System.Windows.Forms.Button btnBubbleSorting;
        private System.Windows.Forms.Button btnClear;
    }
}

