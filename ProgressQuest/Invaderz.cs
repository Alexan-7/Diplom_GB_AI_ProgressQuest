using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressQuest
{
    public partial class Invaderz : MaterialForm
    {
        int DroneSpeed = 1, leftMostDrone = 0, count = 0, dt  = 1, live = 3, score = 0;

        Piece _rocket;
        List<Piece> _bullets = new List<Piece>();

        // собственно захватнические БПЛА
        Bitmap _mainDroneImage = Properties.Resources.bossDrone;
        List<Bitmap> _droneFrames = new List<Bitmap>();
        Piece[,] _drones = new Piece[3, 8]; // массив дронов
        int[] topDrone = new int[3];

        // Hearts
        List<Piece> _liveHearts = new List<Piece>();

        // Drones Bullets
        Bitmap _mainBrokenBullet = Properties.Resources.eggBreak;
        List<Bitmap> _brokenBulletFrames = new List<Bitmap>();
        List<Piece> _drBullets = new List<Piece>();

        Random rand = new Random(); // Создание экземпляра Random

        public Invaderz()
        {
            InitializeComponent();
            // сразу изменим начальную позицию формы на центр экрана
            this.StartPosition = FormStartPosition.CenterScreen;
            Intial();

            // подписать обработчик события FormClosing в конструкторе
            this.FormClosing += new FormClosingEventHandler(this.Invaderz_FormClosing);
        }

        private void Intial()
        {
            _rocket = new Piece(100, 100);
            _rocket.Left = Width / 2 - _rocket.Width / 2;
            _rocket.Top = Height - _rocket.Height;
            _rocket.Image = Properties.Resources.ship;
            Controls.Add(_rocket);

            divideImageIntoFrames(_mainDroneImage, _droneFrames, 24);

            createDrones();

            createHearts();

            divideImageIntoFrames(_mainBrokenBullet, _brokenBulletFrames, 8);
        }

        private void createHearts()
        {
            Bitmap heart = Properties.Resources.heart;
            for (int i = 0; i < 3; i++)
            {
                _liveHearts.Add(new Piece(50, 50));
                _liveHearts[i].Image = heart;
                _liveHearts[i].Left = Width - (3 - i) * 45;
                _liveHearts[i].Top = Height - 155;
                Controls.Add(_liveHearts[i]);

            }
        }

        private void createDrones()
        {
            Bitmap img = _droneFrames[0];
            for (int i = 0; i < 3; i++)
            {
                topDrone[i] = i * 100 + img.Height;
                for (int j = 0; j < 8; j++)
                {
                    Piece drone = new Piece(img.Width, img.Height);
                    drone.Image = img;
                    drone.Left = j * 100;
                    drone.Top = i * 100 + img.Height;
                    _drones[i, j] = drone;
                    Controls.Add(drone);
                }
            }
        }

        private void divideImageIntoFrames(Bitmap orignal, List<Bitmap> res, int n)
        {
            int w = orignal.Width / n, h = orignal.Height;
            for (int i = 0; i < n; i++)
            {
                int s = i * w;
                Bitmap piece = new Bitmap(w, h);
                for (int j = 0; j < h; j++)
                    for (int k = 0; k < w; k++)
                        piece.SetPixel(k, j, orignal.GetPixel(k + s, j)) ;
                res.Add(piece);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "!!! Zахватчики – invaderZ !!!";
            //this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;

            this.ControlBox = false;

            // путь к нашему MIDI-файлу
            string midiFilePath = @"Bunker3D.mid";
            axWindowsMediaPlayer1.Visible = false;

            // Включим режим повторения
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            // Воспроизведем MIDI-файл
            axWindowsMediaPlayer1.URL = midiFilePath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Invaderz_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _rocket.Left -= 10;
                    break;
                case Keys.Right:
                    _rocket.Left += 10;
                    break;
                /* case Keys.Up:
                    _rocket.Top -= 10;
                    break;
                case Keys.Down:
                    _rocket.Top += 10;
                    break; */
            }
        }

        private void drBulTm_Tick(object sender, EventArgs e)
        {
            if (rand.Next(150) == 15) launchRandomBullet();
            // если случайно сгенерированное число от 0 до 149 равно 15,
            // то будет вызвана функция launchRandomBullet()

            // let eggs move down
            for (int i = 0; i < _drBullets.Count; i++)
            {
                _drBullets[i].Top += _drBullets[i].bullDownSpeed;
                // bullet[i] crash with rocket
                if (_rocket.Bounds.IntersectsWith(_drBullets[i].Bounds))
                {
                    Controls.Remove(_drBullets[i]); _drBullets.RemoveAt(i);
                    decreaseLive();
                    break;
                }
                if (_drBullets[i].Top >= Height - (_drBullets[i].Height + 20))
                {
                    _drBullets[i].bullDownSpeed = 0;
                    if (_drBullets[i].bullLandCount / 2 < _brokenBulletFrames.Count)
                    {
                        _drBullets[i].Image
                            = _brokenBulletFrames[_drBullets[i].bullLandCount / 2];
                        _drBullets[i].bullLandCount += 1;
                    }
                    else
                    {
                        Controls.Remove(_drBullets[i]); _drBullets.RemoveAt(i);
                    }
                }
            }
        }

        private void decreaseLive()
        {
            live -= 1;
            _liveHearts[live].Image = Properties.Resources.d_heart;
            if (live < 1) endGame(Properties.Resources.lose);
            Controls.Add(GameMenu); // Добавление элемента GameMenu
        }

        private void endGame(Bitmap img)
        {
            drBulTm.Stop(); bulletsTm.Stop(); droneTm.Stop(); // останавливаются таймеры
            Controls.Clear(); // очистка всех элементов управления на форме
            Piece pic = new Piece(100, 100); // Создается новый экземпляр класса Piece
            pic.Click += cls;
            pic.Image = img;
            pic.Left = Width / 2 - pic.Width / 2;
            pic.Top = Height / 2 - pic.Height / 2;
            Controls.Add(pic);
        }

        private void cls(object sender, EventArgs e)
        {
            this.Close();
        }

        private void launchRandomBullet()
        {
            List<Piece> availablesDrones = new List<Piece>();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 8; j++)
                    if (_drones[i, j] != null)
                        availablesDrones.Add(_drones[i, j]);  // элемент, находящийся на позиции i, j в массиве _drones,
                                                              // добавляется в список availablesDrones

            // select random drone to drop egg from it
            Piece drone = availablesDrones[rand.Next() % availablesDrones.Count]; // из списка доступных дронов (availablesDrones)
                                                                                  // выбирается элемент случайным образом с использованием
                                                                                  // метода Next() объекта rand. Для обеспечения корректного
                                                                                  // выбора используется операция остатка от деления по
                                                                                  // модулю на количество элементов в списке, полученное
                                                                                  // через Count(). Выбранный элемент сохраняется в переменной
                                                                                  // drone типа Piece для последующего использования.
            Piece drBul = new Piece(24, 32);
            drBul.Image = Properties.Resources.egg;
            drBul.Left = drone.Left + drone.Width / 2 - drBul.Width / 2;
            drBul.Top = drone.Top + drone.Height;
            _drBullets.Add(drBul); Controls.Add(drBul);
        }

        private bool isExiting = false;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Остановим воспроизведение, если закроют окно раньше, чем закончится мелодия
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            isExiting = true; // Устанавливаем флаг того, что происходит выход
            Close();
        }

        private void Invaderz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExiting)
            {
                // Если выход уже был инициирован, просто выходим из метода
                return;
            }
            // Получаем экземпляр материнского окна
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (mainForm != null)
                mainForm.timer1.Start(); // Запускаем таймер в материнском окне
        }

        private void Invaderz_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) launchBullet();
        }

        private void launchBullet()
        {
            Piece bullet = new Piece(10, 10);
            bullet.Left = _rocket.Left + _rocket.Width / 2 - bullet.Width / 2;
            bullet.Top = _rocket.Top - bullet.Height;
            bullet.Image = Properties.Resources.b3; // снаряды самолета
            _bullets.Add(bullet); 
            Controls.Add(bullet); // элемент управления bullet будет добавлен
                                  // в коллекцию элементов управления текущего контейнера.
                                  // Это означает, что bullet теперь будет отображаться
                                  // на форме (или другом контейнере) и будет учитываться
                                  // в процессе отрисовки и обработки событий.
        }

        private void droneTm_Tick(object sender, EventArgs e)
        {
            if (leftMostDrone + 800 > Width || leftMostDrone < 0)
                DroneSpeed = -DroneSpeed;
            leftMostDrone += DroneSpeed;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (_drones[i, j] == null) continue;

                    // Получаем текущий индекс кадра из Tag или устанавливаем случайный, если Tag равен null
                    int currentFrameIndex = _drones[i, j].Tag == null ? rand.Next(0, _droneFrames.Count) : (int)_drones[i, j].Tag;
                    _drones[i, j].Image = _droneFrames[currentFrameIndex]; // Устанавливаем текущий кадр

                    // Увеличиваем индекс, обеспечивая плавную смену
                    currentFrameIndex = (currentFrameIndex + 1) % _droneFrames.Count;
                    _drones[i, j].Tag = currentFrameIndex; // Сохраняем новый индекс в Tag

                    _drones[i, j].Left += DroneSpeed;
                }
            }
        }

        private void bulletsTm_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _bullets.Count; i++)
                _bullets[i].Top -= 3;

            collision();
            if (score == 240) endGame(Properties.Resources.win);
            Controls.Add(GameMenu); // Добавление элемента GameMenu обратно на форму
        }

        private void collision()
        {
            for (int i = 0; i < topDrone.Length; i++)
            {
                // binary search first occurance in bullets
                int lo = 0, hi = _bullets.Count - 1, md, ans = -1;
                while (lo <= hi)
                {
                    md = lo + (hi - lo) / 2;
                    if (_bullets[md].Top >= topDrone[i])
                    {
                        hi = md - 1;
                        ans = md;
                    }
                    else lo = md + 1;
                }
                if (ans != -1 && _bullets[ans].Top >= topDrone[i]
                    && _bullets[ans].Top <= topDrone[i] + _droneFrames[0].Height)
                {
                    int j = (_bullets[ans].Left + 9 - leftMostDrone) / 100;
                    if (j >= 0 && j < 8 && _drones[i, j] != null
                        && _bullets[ans].Bounds.IntersectsWith(_drones[i, j].Bounds))
                    {
                        Controls.Remove(_bullets[ans]);
                        _bullets.RemoveAt(ans);
                        Controls.Remove(_drones[i, j]);
                        _drones[i, j] = null;
                        score += 10;
                        lblScore.Text = "Score: " + score.ToString();
                    }
                }
            }
        }
    }
}