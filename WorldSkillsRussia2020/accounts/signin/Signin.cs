using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSkillsRussia2020.admin;
using WorldSkillsRussia2020.handlers;
using WorldSkillsRussia2020.Signup;

namespace WorldSkillsRussia2020
{
    public partial class Signin : Form
    {
        // Инициализация переменной Point.
        Point lastpoint;


        public Signin()
        {
        // MessageBox с сообщениями.
        MsgBox msgbox = new MsgBox();
            InitializeComponent();

            // Инициализация переменной таймера.
            byte timesinarow = 0;
            // Установка таймера на 15 сек.
            timer.Interval = 15000;

            // Кнопка Свернуть.
            signInWinState.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // Замена цвета кнопки Свернуть.
            signInWinState.MouseEnter += (s, a) => { signInWinState.BackColor = Color.MediumSpringGreen; };
            signInWinState.MouseLeave += (s, a) => { signInWinState.BackColor = Color.MediumSeaGreen; };

            // Кнопка Закрыть.
            xExit.Click += (s, a) => { Dispose(); };
            // Замена цвета кнопки Закрыть.
            xExit.MouseEnter += (s, a) => { xExit.BackColor = Color.Red; };
            xExit.MouseLeave += (s, a) => { xExit.BackColor = Color.MediumSeaGreen; };

            // Отключение перехода по нажатию клавиши Enter в textBox'ах.
            // Логин.
            loginField.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    a.SuppressKeyPress = true;
            };
            // Пароль.
            passwordField.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    a.SuppressKeyPress = true;
            };

            // Перетаскивание окна по ЛКМ.
            header_text.MouseMove += (s, a) =>
            {
                if (a.Button == MouseButtons.Left)
                {
                    Left += a.X - lastpoint.X;
                    Top += a.Y - lastpoint.Y;
                }
            };
            // Новые координаты для окна.
            header_text.MouseDown += (s, a) => { lastpoint = new Point(a.X, a.Y); };

            // Событие Enter для кнопки Войти.
            KeyUp += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    signinBtn.PerformClick();
            };

            // Замена цвета при наведении у кнопки Войти.
            signinBtn.MouseEnter += (s, a) =>
            {
                signinBtn.BackColor = Color.SeaGreen;
                signinBtn.ForeColor = Color.MistyRose;
            };
            signinBtn.MouseLeave += (s, a) =>
            {
                signinBtn.BackColor = Color.LightGray;
                signinBtn.ForeColor = Color.DarkSlateGray;
            };

            // Обработчик - Еще нет аккаунта?
            signupLabel.Click += (s, a) =>
            {
                Hide();
                var signup = new signUp();
                signup.Show();
            };

            // Событие label Изменить пароль.
            passChangeLb.Click += (s, a) =>
            {
                Hide();
                var changepass = new ChangePass();
                changepass.Show();
            };

            // Обработчик кнопки - Войти.
            signinBtn.Click += async (s, a) =>
            {
                // Чтение textBox'ов авторизации.
                string login = loginField.Text;
                string password = passwordField.Text;
                string rights = "user";

                // Экземпляры классов.
                // Подключение к БД.
                var dB = new DB();
                var sqlDataAdapter = new SqlDataAdapter();
                var dataTable = new DataTable();

                // Запрос в БД.
                var sqlCommand = new SqlCommand("SELECT * FROM [Users] WHERE [Login]=@Login AND [Password]=@Password AND [Rights]=@Rights", dB.getConnection());

                // Заглушки для входных данных.
                sqlCommand.Parameters.Add("@Login", SqlDbType.NVarChar).Value = login;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                sqlCommand.Parameters.Add("@Rights", SqlDbType.NVarChar).Value = rights;

                // Какая команда будет использоваться.
                sqlDataAdapter.SelectCommand = sqlCommand;

                // Запись входных данных в табличном представлении.
                sqlDataAdapter.Fill(dataTable);

                // Проверка того, есть ли хоть 1 пользовать в БД.
                if (dataTable.Rows.Count > 0)
                {

                    //if (dataTable.)
                    //{

                    //}
                    Hide();
                    var userform = new UserForm();
                    userform.Show();
                }

                // Вывод формы смены пароля, если пользователь не заходил в систему 14 дней.
                //var changepass = new ChangePass();
                //changepass.changePass();

                // Обработчик таймера.
                string passtimer = "", desctimer = descTimer.Text;

                if (timesinarow < 2)
                {
                    // Проверка полей на пустоту.
                    if (passtimer == passwordField.Text || loginField.Text == "")
                    {
                        timesinarow = 0;
                        descTimer.Text = "Одно или более полей пусты!";
                        await Task.Delay(4000);
                        descTimer.Text = "";
                    }
                    else
                    {
                        timesinarow++;
                        descAttempt.Text = $"Использовано попыток: {timesinarow.ToString()}";
                        await Task.Delay(4000);
                        descAttempt.Text = "";
                        descTimer.Text = "Вы ввели неверный логин или пароль!";
                        await Task.Delay(4000);
                        descTimer.Text = "";
                    }
                }
                else
                {
                    descAttempt.Text = $"Количество попыток исчерпано! Подождите {timer.Interval / 1000} сек.";
                    timesinarow = 0;
                    loginField.ReadOnly = true;
                    passwordField.ReadOnly = true;
                    timer.Enabled = true;
                    signinBtn.Enabled = false;
                    await Task.Delay(timer.Interval);
                    descAttempt.Text = "";
                }
            };

            // Таймер. Блокировка системы на 15 сек. в первый раз с последующей блокировкой на 20 сек. за неправильный блок.
            timer.Tick += (s, a) =>
            {
                signinBtn.Enabled = true;
                loginField.ReadOnly = false;
                passwordField.ReadOnly = false;
                loginField.Text = "";
                passwordField.Text = "";
                timer.Enabled = false;
                loginField.Focus();
                timer.Interval = timer.Interval + 90000;
            };
        }
    }
}
