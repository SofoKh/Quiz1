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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (q9a2.Checked)
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

                ///reader.ReadToEnd
            }
            Form10 form10 = new Form10();
            Hide();
            form10.Show();
            file.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
