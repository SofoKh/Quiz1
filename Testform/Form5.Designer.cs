
namespace Testform
{
    partial class Form5
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
            this.q5a2 = new System.Windows.Forms.RadioButton();
            this.q5a1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(44, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(123, 25);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Question #5:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "თუ გვინდა რომ დელეგატი იყოს მრავალ მისამართიანი, მისი ტიპი აუცილებლად უნდა იყოს V" +
    "oid";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q5a2);
            this.panel1.Controls.Add(this.q5a1);
            this.panel1.Location = new System.Drawing.Point(49, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 143);
            this.panel1.TabIndex = 7;
            // 
            // q5a2
            // 
            this.q5a2.AutoSize = true;
            this.q5a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q5a2.Location = new System.Drawing.Point(13, 86);
            this.q5a2.Name = "q5a2";
            this.q5a2.Size = new System.Drawing.Size(57, 22);
            this.q5a2.TabIndex = 1;
            this.q5a2.TabStop = true;
            this.q5a2.Text = "false";
            this.q5a2.UseVisualStyleBackColor = true;
            // 
            // q5a1
            // 
            this.q5a1.AutoSize = true;
            this.q5a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q5a1.Location = new System.Drawing.Point(13, 27);
            this.q5a1.Name = "q5a1";
            this.q5a1.Size = new System.Drawing.Size(51, 22);
            this.q5a1.TabIndex = 0;
            this.q5a1.TabStop = true;
            this.q5a1.Text = "true";
            this.q5a1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(256, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "შემდეგი";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton q5a2;
        private System.Windows.Forms.RadioButton q5a1;
        private System.Windows.Forms.Button button3;
    }
}