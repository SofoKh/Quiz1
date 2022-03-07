
namespace Testform
{
    partial class Form4
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
            this.question4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q4a3 = new System.Windows.Forms.RadioButton();
            this.q4a2 = new System.Windows.Forms.RadioButton();
            this.q4a1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(46, 83);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(123, 25);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Question #4:";
            // 
            // question4
            // 
            this.question4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question4.Location = new System.Drawing.Point(48, 108);
            this.question4.Name = "question4";
            this.question4.Size = new System.Drawing.Size(788, 71);
            this.question4.TabIndex = 5;
            this.question4.Text = "საფაილო მიმთითებლის მნიშვნელობის შესაცვლელად გამოიყენებაSeek() მეთოდი , რომელ ფუნ" +
    "ქციას ვიყენებთ ფაილის დასაწყისიდან გადათვლისთვის?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q4a3);
            this.panel1.Controls.Add(this.q4a2);
            this.panel1.Controls.Add(this.q4a1);
            this.panel1.Location = new System.Drawing.Point(51, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 143);
            this.panel1.TabIndex = 7;
            // 
            // q4a3
            // 
            this.q4a3.AutoSize = true;
            this.q4a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4a3.Location = new System.Drawing.Point(13, 107);
            this.q4a3.Name = "q4a3";
            this.q4a3.Size = new System.Drawing.Size(126, 22);
            this.q4a3.TabIndex = 3;
            this.q4a3.TabStop = true;
            this.q4a3.Text = "FromBeginning";
            this.q4a3.UseVisualStyleBackColor = true;
            // 
            // q4a2
            // 
            this.q4a2.AutoSize = true;
            this.q4a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4a2.Location = new System.Drawing.Point(13, 62);
            this.q4a2.Name = "q4a2";
            this.q4a2.Size = new System.Drawing.Size(63, 22);
            this.q4a2.TabIndex = 1;
            this.q4a2.TabStop = true;
            this.q4a2.Text = "Begin";
            this.q4a2.UseVisualStyleBackColor = true;
            // 
            // q4a1
            // 
            this.q4a1.AutoSize = true;
            this.q4a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4a1.Location = new System.Drawing.Point(13, 20);
            this.q4a1.Name = "q4a1";
            this.q4a1.Size = new System.Drawing.Size(93, 22);
            this.q4a1.TabIndex = 0;
            this.q4a1.TabStop = true;
            this.q4a1.Text = "FromStart";
            this.q4a1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(304, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "შემდეგი";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.question4);
            this.Controls.Add(this.lbl1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label question4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton q4a3;
        private System.Windows.Forms.RadioButton q4a2;
        private System.Windows.Forms.RadioButton q4a1;
        private System.Windows.Forms.Button button3;
    }
}