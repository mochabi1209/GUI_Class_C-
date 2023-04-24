
namespace N10310019_1
{
    partial class Form_Exception
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
            this.textBox_Add1 = new System.Windows.Forms.TextBox();
            this.textBox_Add2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Add1
            // 
            this.textBox_Add1.Location = new System.Drawing.Point(193, 142);
            this.textBox_Add1.Name = "textBox_Add1";
            this.textBox_Add1.Size = new System.Drawing.Size(100, 22);
            this.textBox_Add1.TabIndex = 0;
            // 
            // textBox_Add2
            // 
            this.textBox_Add2.Location = new System.Drawing.Point(362, 143);
            this.textBox_Add2.Name = "textBox_Add2";
            this.textBox_Add2.Size = new System.Drawing.Size(100, 22);
            this.textBox_Add2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(529, 146);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(10, 12);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Exception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Add2);
            this.Controls.Add(this.textBox_Add1);
            this.Name = "Form_Exception";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form_Exception_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Add1;
        private System.Windows.Forms.TextBox textBox_Add2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button1;
    }
}