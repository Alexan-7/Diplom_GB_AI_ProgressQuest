using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressQuest
{
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Разработчик программы - студент GeekBrains\nБердюгин Александр Александрович\n" +
                "(факультет «Инженер искусственного интеллекта»)\n\n";
            linkLabel1.Text = "Профиль автора на GeekBrains";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно перейти по ссылке.");
            }
        }

        private void VisitLink()
        {
            // изменение цвета ссылки
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://gb.ru/users/cf7e1e7d-901b-47bf-8976-7e94a1133375");
        }
    }
}