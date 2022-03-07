using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Testform
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (q10a4.Checked)
            {
                FileStream file = new FileStream("C:/Users/xvr43/source/repos/Testform/Testform/bin/Debug/‪‪Score.txt", FileMode.OpenOrCreate);
                StreamReader reader = new StreamReader(file);
                StreamWriter writer = new StreamWriter(file);
                int currentScore = 0;

                try
                {
                    currentScore = Convert.ToInt32(reader.ReadToEnd());
                    currentScore += 1;

                }
                catch (Exception x)
                {
                    MessageBox.Show("Failshi ricxvi ar weria,gtxovt,tavidan gaiarot testi");
                    currentScore = 0;
                }

                file.SetLength(0);
                writer.WriteLine(currentScore);
                file.Close();

                ///reader.ReadToEnd
            }
            string message = "Done. Do you wish to see your results and correct answers?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string title = "Almost Done...!";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form11 form11 = new Form11();
                Hide();
                form11.Show();
            }
            else
            {
                Hide();
                string message1 = " ok lmao";
                string title1 = "weird choice";
                MessageBox.Show(message1,title1);
            }
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
