using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSkillsRussia2020.handlers;

namespace WorldSkillsRussia2020.Signup
{
    public partial class signUp : Form
    {
            // Иниц. точки.
            internal Point lastpoint;
        public signUp() {
            InitializeComponent();

            // Соединение с БД.
            DB dB = new DB();

            // Вызов MessageBox.
            MsgBox msgbox = new MsgBox();
            // Кнопка Свернуть.
            signInWinState.Click += (s, a) => { WindowState = FormWindowState.Minimized; };
            // Замена цвета у кнопки Свернуть.
            signInWinState.MouseEnter += (s, a) => { signInWinState.BackColor = Color.DodgerBlue; };
            signInWinState.MouseLeave += (s, a) => { signInWinState.BackColor = Color.Blue; };

            // Кнопка Закрыть.
            xExit.Click += (s, a) => { Dispose(); };
            // Замена цвета кнопки Закрыть.
            xExit.MouseEnter += (s, a) => { xExit.BackColor = Color.Red; };
            xExit.MouseLeave += (s, a) => { xExit.BackColor = Color.Blue; };

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

            // Событие Enter для кнопки Зарегистрироваться.
            KeyUp += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    signUpBtn.PerformClick();
            };

            // Замена цвета при наведении у кнопки Зарегистрироваться.
            signUpBtn.MouseEnter += (s, a) =>
            {
                signUpBtn.BackColor = Color.DodgerBlue;
                signUpBtn.ForeColor = Color.MistyRose;
            };
            signUpBtn.MouseLeave += (s, a) =>
            {
                signUpBtn.BackColor = Color.LightGray;
                signUpBtn.ForeColor = Color.DarkSlateGray;
            };

            // Обработчик - Уже есть аккаунт?
            signinLabel.Click += (s, a) =>
            {
                Hide();
                var signin = new ChangePass();
                signin.Show();
            };

            // Обработчик кнопки Signup.
            signUpBtn.Click += async (s, a) =>
            {
                // Проверка полей Логин и Пароль на пустоту.
                if (loginField.Text == "" || passwordField.Text == "")
                {
                    regMsgLb.Visible = true;
                    regMsgLb.ForeColor = Color.Red;
                    regMsgLb.Text = "Одно или более полей не заполнено!";
                    await Task.Delay(4000);
                    regMsgLb.Visible = false;
                    return;
                }

                // Если пользователь ввел логин.
                if (userLoginCheck())
                    return;

                // Если пользователь ввел все данные, регистрируем.
                // Регистрация пользователя в БД.
                var sqlCommand = new SqlCommand("INSERT INTO [Users] ([Login], [Password]) VALUES (@Login, @Password)", dB.getConnection());

                string login = loginField.Text;
                string password = passwordField.Text;
                // Заглушки для входных данных.
                sqlCommand.Parameters.Add("@Login", SqlDbType.NVarChar).Value = login;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                dB.openConnection();

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    Hide();
                    var signin = new Signin();
                    signin.Show();
                    msgbox.succMsgBox(succmsgbox: "Аккаунт был создан! Вы можете войти!");

                }
                else
                    msgbox.errMsgBox(errmsgbox: "Аккаунт не был создан!");

                dB.closeConnection();
            };

            // Если пользователь с таким логином уже существует, не регистрируем.
            bool userLoginCheck()
            {
                var dataTable = new DataTable();
                var sqlDataAdapter = new SqlDataAdapter();

                var sqlCommand = new SqlCommand("SELECT * FROM [Users] WHERE [Login] = @uL", dB.getConnection());
                sqlCommand.Parameters.Add("@uL", SqlDbType.NVarChar).Value = loginField.Text;

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    regMsgLb.ForeColor = Color.Red;
                    regMsgLb.Text = "Пользователь с таким логином уже существует, введите другой!";
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
