
namespace Testform
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.question2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q2a2 = new System.Windows.Forms.RadioButton();
            this.q2a1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(46, 85);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(123, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Question #2:";
            // 
            // question2
            // 
            this.question2.AutoSize = true;
            this.question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2.Location = new System.Drawing.Point(48, 138);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(402, 18);
            this.question2.TabIndex = 3;
            this.question2.Text = " C#ში შეიძლება კლასს ორი მშობელი კლასი ჰყავდეს.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q2a2);
            this.panel1.Controls.Add(this.q2a1);
            this.panel1.Location = new System.Drawing.Point(51, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 143);
            this.panel1.TabIndex = 5;
            // 
            // q2a2
            // 
            this.q2a2.AutoSize = true;
            this.q2a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2a2.Location = new System.Drawing.Point(13, 86);
            this.q2a2.Name = "q2a2";
            this.q2a2.Size = new System.Drawing.Size(57, 22);
            this.q2a2.TabIndex = 1;
            this.q2a2.TabStop = true;
            this.q2a2.Text = "false";
            this.q2a2.UseVisualStyleBackColor = true;
            // 
            // q2a1
            // 
            this.q2a1.AutoSize = true;
            this.q2a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2a1.Location = new System.Drawing.Point(13, 27);
            this.q2a1.Name = "q2a1";
            this.q2a1.Size = new System.Drawing.Size(51, 22);
            this.q2a1.TabIndex = 0;
            this.q2a1.TabStop = true;
            this.q2a1.Text = "true";
            this.q2a1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "შემდეგი";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label question2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton q2a2;
        private System.Windows.Forms.RadioButton q2a1;
        private System.Windows.Forms.Button button2;
    }
}