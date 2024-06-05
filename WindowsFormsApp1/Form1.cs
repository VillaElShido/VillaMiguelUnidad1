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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Enter += new EventHandler(Control_Enter);
            button2.Enter += new EventHandler(Control_Enter);
            textBox1.Enter += new EventHandler(Control_Enter);
            textBox2.Enter += new EventHandler(Control_Enter);
            label1.Enter += new EventHandler(Control_Enter);
            listBox1.Enter += new EventHandler(Control_Enter);
            comboBox1.Enter += new EventHandler(Control_Enter);
            radioButton1.Enter += new EventHandler(Control_Enter);
            dateTimePicker1.Enter += new EventHandler(Control_Enter);


            comboBox1.MouseHover += new EventHandler(Control_MouseHover);
            button1.MouseHover += new EventHandler(Control_MouseHover);
            button2.MouseHover += new EventHandler(Control_MouseHover);
            textBox1.MouseHover += new EventHandler(Control_MouseHover);
            textBox2.MouseHover += new EventHandler(Control_MouseHover);
            label1.MouseHover += new EventHandler(Control_MouseHover);
            radioButton1.MouseHover += new EventHandler(Control_MouseHover);
            listBox1.MouseHover += new EventHandler(Control_MouseHover);
            dateTimePicker1.MouseHover += new EventHandler(Control_MouseHover);

        }

        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                label2.Text = $"Foco en: {control.Name} - Tipo: {control.GetType().Name}";
            }

        }

        private void Control_MouseHover(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                label2.Text = $"MouseHover en: {control.Name} - Tipo: {control.GetType().Name}";
            }
        }
    }
}
