using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WorldSkillsRussia2020.handlers
{
    public partial class ChangePass : Form
    {
        Point lastpoint;
        public ChangePass()
        {
            InitializeComponent();

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

            changePassBtn.Click += (s, a) =>
            {
                var dB = new DB();
                var sqlDataAdapter = new SqlDataAdapter();
                var dataTable = new DataTable();


            };
        }
    }
}
