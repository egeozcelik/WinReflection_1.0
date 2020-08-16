using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WinReflection
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            User user1 = new User();
        private void Form1_Load(object sender, EventArgs e)
        {
            user1.Id = 1;
            user1.Name = "ege";
            user1.Surname = "ozcelik";

        }

        public static void setValue(object container, string propertyName, object value)
        {
            container.GetType().GetProperty(propertyName).SetValue(container, value);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValue(user1, "Name", textBox1.Text);
            listBox1.Items.Add(user1.Name);
        }

      
    }
}
