
namespace Testform
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
            this.title = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.question1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q1a3 = new System.Windows.Forms.RadioButton();
            this.q1a2 = new System.Windows.Forms.RadioButton();
            this.q1a1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(275, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(55, 27);
            this.title.TabIndex = 0;
            this.title.Text = "Quiz";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(48, 84);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(119, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Question #1:";
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1.Location = new System.Drawing.Point(49, 130);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(253, 23);
            this.question1.TabIndex = 2;
            this.question1.Text = "როგორი კლასია სტატიკური?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q1a3);
            this.panel1.Controls.Add(this.q1a2);
            this.panel1.Controls.Add(this.q1a1);
            this.panel1.Location = new System.Drawing.Point(44, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 143);
            this.panel1.TabIndex = 4;
            // 
            // q1a3
            // 
            this.q1a3.AutoSize = true;
            this.q1a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1a3.Location = new System.Drawing.Point(13, 103);
            this.q1a3.Name = "q1a3";
            this.q1a3.Size = new System.Drawing.Size(439, 22);
            this.q1a3.TabIndex = 2;
            this.q1a3.TabStop = true;
            this.q1a3.Text = "კლასი,რომელსაც მხოლოდ ანონიმური მეთოდები აქვს.";
            this.q1a3.UseVisualStyleBackColor = true;
            // 
            // q1a2
            // 
            this.q1a2.AutoSize = true;
            this.q1a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1a2.Location = new System.Drawing.Point(13, 66);
            this.q1a2.Name = "q1a2";
            this.q1a2.Size = new System.Drawing.Size(542, 22);
            this.q1a2.TabIndex = 1;
            this.q1a2.TabStop = true;
            this.q1a2.Text = "კლასი რომელშიც მხოლოდ int ობიექტებთან შესაძლებელია მუშაობა";
            this.q1a2.UseVisualStyleBackColor = true;
            // 
            // q1a1
            // 
            this.q1a1.AutoSize = true;
            this.q1a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1a1.Location = new System.Drawing.Point(13, 27);
            this.q1a1.Name = "q1a1";
            this.q1a1.Size = new System.Drawing.Size(357, 22);
            this.q1a1.TabIndex = 0;
            this.q1a1.TabStop = true;
            this.q1a1.Text = "კლასი რომელსაც არ გააჩნია კონსტრუქტორი";
            this.q1a1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "შემდეგი";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.question1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton q1a3;
        private System.Windows.Forms.RadioButton q1a2;
        private System.Windows.Forms.RadioButton q1a1;
        private System.Windows.Forms.Button button1;
    }
}

