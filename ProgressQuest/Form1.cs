using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace ProgressQuest
{
    public partial class Form1 : MaterialForm
    {
        int money = 10000;
        bool keyPressed = false;
        bool isGame = false;

        // quiz game wariables
        int correctAnswer; // порядковый номер правильного ответа
        int score;

        // Чтобы русские буквы читались корректно, объявляем объект kodirovka
        System.Text.Encoding kodirovka =
            System.Text.Encoding.GetEncoding("UTF-8");
        System.IO.StreamReader Reader = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\test.quiz");

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Файлы игры ProgressQuest (*.pqst)|*.pqst|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Файлы игры ProgressQuest (*.pqst)|*.pqst|All files(*.*)|*.*";

            KeyPreview = true;
            label1.Text = "Настроение\nи здоровье";
            label2.Text = "Отношения\nс людьми";
            label3.Text = "Эрудиция\nи IQ";
            label4.Text = "Недовольство\nжизнью";
            askQuestion();
            this.AutoScaleMode = AutoScaleMode.Dpi; // Масштаб элементов управления изменяется
                                                    // в соответствии с разрешением экрана.
                                                    // Стандартное разрешение — 96 и 120 точек
                                                    // на дюйм.
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ifrm1 = new Form2();
            ifrm1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pB1.Value--;
            pB2.Value--;
            pB3.Value--;
            pB4.Value = (pB1.Maximum - pB1.Value) + (pB2.Maximum - pB2.Value) + (pB3.Maximum - pB3.Value);
            //предупреждение про падение жизненных показателей
            if (pB4.Value == pB1.Maximum || pB4.Value == pB4.Maximum / 2
                || pB4.Value == pB1.Maximum * 2)
            {
                MessageBox.Show("Если упадут показатели - обижусь и уйду:(", "Недовольство растет", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (pB1.Value == 0 | pB2.Value == 0 | pB3.Value == 0)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pB4.Maximum = pB1.Maximum + pB2.Maximum + pB3.Maximum;
            pB1.Value = pB1.Maximum;
            pB2.Value = pB2.Maximum;
            pB3.Value = pB3.Maximum;
            pB4.Value = pB4.Minimum;
            lblMoney.Text = money.ToString("n");
            pictureBox1.Image = imageList1.Images[2];
            pictureBox2.Image = imageList1.Images[5];
            lblMoney.Text = money.ToString("n");
            SoundPlayer simpleSound1 = new SoundPlayer(Properties.Resources.INTRO1);
            simpleSound1.Play();
            паузаToolStripMenuItem.Enabled = false;
            questTextBox.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ifrm2 = new Form3();
            ifrm2.Show();
        }

        private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        // https://youtu.be/mO8te-zu3Zs - простое сохранение
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filePath = saveFileDialog1.FileName;
            // сохраняем текст в файл
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.Write(pB1.Value + "\n");
                streamWriter.Write(pB2.Value + "\n");
                streamWriter.Write(pB3.Value + "\n");
                streamWriter.Write(pB4.Value + "\n");
                streamWriter.Write(money);
            }
            MessageBox.Show("Файл прогресса сохранен");
        }

        private void загрузитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filePath = openFileDialog1.FileName;
            using (StreamReader streamReader = new StreamReader(openFileDialog1.FileName))
            {
                string line;
                if ((line = streamReader.ReadLine()) != null)
                    pB1.Value = Convert.ToInt32(line);
                if ((line = streamReader.ReadLine()) != null)
                    pB2.Value = Convert.ToInt32(line);
                if ((line = streamReader.ReadLine()) != null)
                    pB3.Value = Convert.ToInt32(line);
                if ((line = streamReader.ReadLine()) != null)
                    pB4.Value = Convert.ToInt32(line);
                if ((line = streamReader.ReadLine()) != null)
                    lblMoney.Text = line;
            MessageBox.Show("Файл прогресса открыт");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // https://www.cyberforum.ru/windows-forms/thread2450759.html
            if (e.KeyValue == (Char)Keys.A & !keyPressed)
            {
                if (pB1.Value == pB1.Maximum) ;
                else
                {
                    pictureBox1.Image = imageList1.Images[1];
                    pB1.Value += 2;
                    pB3.Value--;
                    money -= 100;
                    lblMoney.Text = money.ToString("n");
                }
            }
            if (e.KeyValue == (Char)Keys.S & !keyPressed)
            {
                if (pB2.Value == pB2.Maximum) ;
                else
                {
                    pB2.Value += 2;
                    pB1.Value--;
                    pictureBox1.Image = imageList1.Images[3];
                    money += 2500;
                    lblMoney.Text = money.ToString("n");
                }
            }
            if (e.KeyValue == (Char)Keys.D & !keyPressed)
            {
                if (pB3.Value == pB3.Maximum) ;
                else
                {
                    pB3.Value += 2;
                    pictureBox1.Image = imageList1.Images[4];
                    money -= 500;
                    lblMoney.Text = money.ToString("n");
                }
            }

            if (e.KeyValue == (Char)Keys.W & !keyPressed)
            {
                if (pB4.Value == pB4.Minimum) ;
                else
                {
                    pB4.Value -= 20;
                    pictureBox1.Image = imageList1.Images[6];
                    money -= 5000;
                    lblMoney.Text = money.ToString("n");
                }
            }
            keyPressed = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyPressed = false;
        }

        private void questTextBox_SelectionChanged(object sender, EventArgs e)
        {
            this.questTextBox.SelectionStart = this.questTextBox.Text.Length;
            questTextBox.Enabled = false;
            questTextBox.Enabled = true;
        }

        private void questTextBox_Enter(object sender, EventArgs e)
        {
            /* В C# вы можете отключить курсор в текстовом поле, временно отключив, 
            * а затем снова включив текстовое поле всякий раз, когда оно получает 
            * фокус. Обратите внимание, что нет необходимости делать текстовое 
            * поле только для чтения при использовании этого метода.*/

            questTextBox.Enabled = false;
            questTextBox.Enabled = true;
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound2 = new SoundPlayer(Properties.Resources.TecnhoDiplom);
            simpleSound2.Play();
            // https://www.dertz.in/ringtones/wav/?s=20 - источник звуков, чтобы не потерять
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
            pB1.Value = pB1.Maximum;
            pB2.Value = pB2.Maximum;
            pB3.Value = pB3.Maximum;
            money = 10000;
            lblMoney.Text = money.ToString("n");
            timer1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            паузаToolStripMenuItem.Enabled = true;
            playSimpleSound();
           try
            { // Создание экземпляра StreamReader для чтения из файла
                Reader = new System.IO.
                    StreamReader(System.IO.Directory.GetCurrentDirectory()
                                + @"\test.quiz", kodirovka);
                // При использовании класса `StreamReader` для чтения из файла,
                // чтение всегда начинается с первой строки автоматически
            }
            catch (Exception Ситуация)
            { // Отчет обо всех ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            askQuestion();
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (System.Windows.Forms.Button)sender;
            // параметр (sender) предоставляет ссылку на объект, вызвавший событие
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
                money += 1000;
                lblMoney.Text = money.ToString("n");
                pB3.Value++;
                pictureBox1.Image = imageList1.Images[2];

                SoundPlayer simpleSound3 = new SoundPlayer(Properties.Resources.OK_HACK);
                simpleSound3.Play();
                MessageBox.Show("Это правильный ответ!!! Вы выиграли бублики и плюшки!!!", "УРА-А-А!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                money -= 1500;
                lblMoney.Text = money.ToString("n");
                pictureBox1.Image = imageList1.Images[7];

                SoundPlayer simpleSound2 = new SoundPlayer(Properties.Resources.Woody94);
                simpleSound2.Play();

                /* подсказка Ярослава Вегнера:
                1) Я собираю кнопки в массив
                2) Из этого массива достаю правильную кнопку, 
                   поскольку вы знаете правильный индекс
                3) Из кнопки достаю текст */
                Button[] buttons = { button2, button3, button4, button5 };
                Button correctButton = buttons[correctAnswer - 1];
                string correctAnswerText = correctButton.Text;
                MessageBox.Show("Нет. Правильный ответ - " + correctAnswerText, "Ну ёлки зелёные:(...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            askQuestion();
        }
        void endQuest()
        {
            questTextBox.Text = "";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            MessageBox.Show("Game Over!" + Environment.NewLine +
                // Environment.NewLine возвращает строку,
                // обозначающую в данной среде начало новой строки.
                "Верных ответов: " + score + "." + Environment.NewLine +
                "Нажмите OK, чтобы завершить.");

        }
        private void askQuestion() // вместо функции newGame
        {
            questTextBox.Text = Reader.ReadLine();
            // Считывание вариантов ответа:
            button2.Text = Reader.ReadLine();
            button3.Text = Reader.ReadLine();
            button4.Text = Reader.ReadLine();
            button5.Text = Reader.ReadLine();

            string input = Reader.ReadLine();
            if (!string.IsNullOrEmpty(input))
                // Выясняем, какой ответ - правильный:
                correctAnswer = int.Parse(input);
            else endQuest(); // завершаем опрос , если строка пустая или null
        }

        private void gamePaused()
        {
            return;
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isGame)
            {
                isGame = false;
                timer1.Enabled = false;
                паузаToolStripMenuItem.Text = "Поехали";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            else
            {
                паузаToolStripMenuItem.Text = "Пауза";
                timer1.Enabled = true;
                isGame = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Invaderz ifrm3 = new Invaderz();
            ifrm3.ShowDialog(); // Использование ShowDialog для блокировки родительской формы
            // Остановим таймер при закрытии дочернего окна
            timer1.Enabled = false;
        }
    }
}