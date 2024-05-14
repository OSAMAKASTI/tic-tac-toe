namespace Tic_Tac
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
            this.bn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bn
            // 
            this.bn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.bn.Location = new System.Drawing.Point(185, 390);
            this.bn.Name = "bn";
            this.bn.Size = new System.Drawing.Size(160, 62);
            this.bn.TabIndex = 0;
            this.bn.Text = "Play";
            this.bn.UseVisualStyleBackColor = true;
            this.bn.Click += new System.EventHandler(this.bn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(74, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.Location = new System.Drawing.Point(74, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2:";
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.text1.Location = new System.Drawing.Point(81, 169);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(413, 48);
            this.text1.TabIndex = 3;
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.text2.Location = new System.Drawing.Point(81, 308);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(413, 48);
            this.text2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 553);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bn);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
    }
}