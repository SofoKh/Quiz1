
namespace Testform
{
    partial class Form3
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q3a3 = new System.Windows.Forms.RadioButton();
            this.q3a2 = new System.Windows.Forms.RadioButton();
            this.q3a1 = new System.Windows.Forms.RadioButton();
            this.question3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(43, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(123, 25);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Question #3:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q3a3);
            this.panel1.Controls.Add(this.q3a2);
            this.panel1.Controls.Add(this.q3a1);
            this.panel1.Location = new System.Drawing.Point(48, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 143);
            this.panel1.TabIndex = 6;
            // 
            // q3a3
            // 
            this.q3a3.AutoSize = true;
            this.q3a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3a3.Location = new System.Drawing.Point(13, 107);
            this.q3a3.Name = "q3a3";
            this.q3a3.Size = new System.Drawing.Size(187, 22);
            this.q3a3.TabIndex = 3;
            this.q3a3.TabStop = true;
            this.q3a3.Text = "არ აქვს მნიშვნელობა";
            this.q3a3.UseVisualStyleBackColor = true;
            // 
            // q3a2
            // 
            this.q3a2.AutoSize = true;
            this.q3a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3a2.Location = new System.Drawing.Point(13, 62);
            this.q3a2.Name = "q3a2";
            this.q3a2.Size = new System.Drawing.Size(194, 22);
            this.q3a2.TabIndex = 1;
            this.q3a2.TabStop = true;
            this.q3a2.Text = "დღევანდელი თარიღი";
            this.q3a2.UseVisualStyleBackColor = true;
            // 
            // q3a1
            // 
            this.q3a1.AutoSize = true;
            this.q3a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3a1.Location = new System.Drawing.Point(13, 20);
            this.q3a1.Name = "q3a1";
            this.q3a1.Size = new System.Drawing.Size(98, 22);
            this.q3a1.TabIndex = 0;
            this.q3a1.TabStop = true;
            this.q3a1.Text = "01/01/0001";
            this.q3a1.UseVisualStyleBackColor = true;
            // 
            // question3
            // 
            this.question3.AutoSize = true;
            this.question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3.Location = new System.Drawing.Point(47, 127);
            this.question3.Name = "question3";
            this.question3.Size = new System.Drawing.Size(574, 18);
            this.question3.TabIndex = 7;
            this.question3.Text = "უპარამეტრო კონსტრუქტორით შექმნილი DateTime -ის default მნიშვნელობაა:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(270, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "შემდეგი";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.question3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton q3a2;
        private System.Windows.Forms.RadioButton q3a1;
        private System.Windows.Forms.Label question3;
        private System.Windows.Forms.RadioButton q3a3;
        private System.Windows.Forms.Button button3;
    }
}