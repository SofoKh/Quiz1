
namespace Testform
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q9a3 = new System.Windows.Forms.RadioButton();
            this.q9a2 = new System.Windows.Forms.RadioButton();
            this.q9a1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(44, 86);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(123, 25);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Question #9:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "რომელი სიმბოლოთი უკავშირდება შვილი კლასი მშობელ კლასს?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q9a3);
            this.panel1.Controls.Add(this.q9a2);
            this.panel1.Controls.Add(this.q9a1);
            this.panel1.Location = new System.Drawing.Point(49, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 143);
            this.panel1.TabIndex = 10;
            // 
            // q9a3
            // 
            this.q9a3.AutoSize = true;
            this.q9a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q9a3.Location = new System.Drawing.Point(13, 107);
            this.q9a3.Name = "q9a3";
            this.q9a3.Size = new System.Drawing.Size(42, 20);
            this.q9a3.TabIndex = 3;
            this.q9a3.TabStop = true;
            this.q9a3.Text = "=>";
            this.q9a3.UseVisualStyleBackColor = true;
            // 
            // q9a2
            // 
            this.q9a2.AutoSize = true;
            this.q9a2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q9a2.Location = new System.Drawing.Point(13, 62);
            this.q9a2.Name = "q9a2";
            this.q9a2.Size = new System.Drawing.Size(34, 29);
            this.q9a2.TabIndex = 1;
            this.q9a2.TabStop = true;
            this.q9a2.Text = ":";
            this.q9a2.UseVisualStyleBackColor = true;
            // 
            // q9a1
            // 
            this.q9a1.AutoSize = true;
            this.q9a1.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q9a1.Location = new System.Drawing.Point(13, 20);
            this.q9a1.Name = "q9a1";
            this.q9a1.Size = new System.Drawing.Size(38, 28);
            this.q9a1.TabIndex = 0;
            this.q9a1.TabStop = true;
            this.q9a1.Text = "+";
            this.q9a1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(245, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "შემდეგი";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton q9a3;
        private System.Windows.Forms.RadioButton q9a2;
        private System.Windows.Forms.RadioButton q9a1;
        private System.Windows.Forms.Button button3;
    }
}