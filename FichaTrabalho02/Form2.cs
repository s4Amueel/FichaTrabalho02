using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FichaTrabalho02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //Form5 f5 = new Form5(textBox1.Text, textBox2.Text);
          // f5.MdiParent = this.ParentForm;
          //f5.Show();
          //this.Close();

            if (textBox2 != null)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Digite algo";
            }
            
                
            
        }
    }
}
