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
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Игра ProgressQuest в жанре Interactive Fiction с элементами Tamagotchi\n" +
                "является дипломным проектом Бердюгина А.А. на курсах GeekBrains\n\n" +
                "Ближе к завершению работы добавлено пасхальное яйцо –\n" +
                "игра в игре «!!! Zахватчики – invaderZ !!!»";
            linkLabel1.Text = "Ссылка на репозиторий с дипломом";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        // https://learn.microsoft.com/ru-ru/dotnet/desktop/winforms/controls/link-to-an-object-or-web-page-with-wf-linklabel-control?view=netframeworkdesktop-4.8
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
            System.Diagnostics.Process.Start("https://github.com/Alexan-7/Diplom_GB_AI_ProgressQuest");
        }
    }
}