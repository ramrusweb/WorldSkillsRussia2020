using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using WorldSkillsRussia2020.handlers;
using System.Threading.Tasks;

namespace WorldSkillsRussia2020.settings.security
{
    internal partial class ChangePassword : Form
    {
        // Иниц. переменной позиции окна.
        Point lastpoint;
        internal ChangePassword()
        {
            InitializeComponent();


            // ToolTip's.
            _collapse.MouseHover += (s, a) => { collToolTip.SetToolTip(_collapse, "Свернуть"); };
            xExit.MouseHover += (s, a) => { exitToolTip.SetToolTip(xExit, "Закрыть"); };

            oldPass.MouseHover += (s, a) => { oldPassToolTip.SetToolTip(oldPass, "Старый пароль"); };
            newPass.MouseHover += (s, a) => { newPassToolTip.SetToolTip(newPass, "Новый пароль"); };
            confPass.MouseHover += (s, a) => { confPassToolTip.SetToolTip(confPass, "Повторите пароль"); };

            // Кнопка Свернуть.
            _collapse.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // Замена цвета кнопки Свернуть.
            _collapse.MouseEnter += (s, a) => { _collapse.BackColor = Color.MediumSpringGreen; };
            _collapse.MouseLeave += (s, a) => { _collapse.BackColor = Color.MediumSeaGreen; };

            // Кнопка Закрыть.
            xExit.Click += (s, a) => { Dispose(); };
            // Замена цвета кнопки Закрыть.
            xExit.MouseEnter += (s, a) => { xExit.BackColor = Color.Red; };
            xExit.MouseLeave += (s, a) => { xExit.BackColor = Color.MediumSeaGreen; };

            // Отключение перехода по нажатию клавиши Enter в textBox'ах.
            // Старый пароль.
            oldPass.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    a.SuppressKeyPress = true;
            };
            // Новый пароль.
            newPass.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    a.SuppressKeyPress = true;
            };
            // Подтвердите пароль.
            confPass.KeyDown += (s, a) =>
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

            // Событие Enter для кнопки Изменить.
            KeyUp += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    changePassBtn.PerformClick();
            };

            // Замена цвета при наведении у кнопки Изменить.
            changePassBtn.MouseEnter += (s, a) =>
            {
                changePassBtn.BackColor = Color.SeaGreen;
                changePassBtn.ForeColor = Color.MistyRose;
            };
            changePassBtn.MouseLeave += (s, a) =>
            {
                changePassBtn.BackColor = Color.LightGray;
                changePassBtn.ForeColor = Color.DarkSlateGray;
            };

            // Кнопка Изменить.
            changePassBtn.Click += async (s, a) =>
            {
               
                // Переменные полей.
                string oldpass = oldPass.Text;
                string newpass = newPass.Text;
                string confpass = confPass.Text;

                var db = new DB();
                var sda = new SqlDataAdapter();
                var dt = new DataTable();

                // Валидация полей.
                if (oldpass == "" || newpass == "" || confpass == "")
                {
                    descAttempt.Text = "Одно или более полей не заполнены!";
                    await Task.Delay(4000);
                    descAttempt.Text = "";
                }
                if (newpass != confpass)
                {
                    descAttempt.Text = "Последние 2 поля не совпадают!";
                    await Task.Delay(4000);
                    descAttempt.Text = "";
                }
                if (oldpass == newpass || oldpass == confpass)
                {
                    descAttempt.Text = "Старый пароль и новый совпадают!";
                    await Task.Delay(4000);
                    descAttempt.Text = "";
                }

                //Dispose();
                //var signin = new Signin();
                //signin.Show();
            };
        }
    }
}
