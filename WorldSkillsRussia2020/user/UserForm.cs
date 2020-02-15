using System.Drawing;
using System.Windows.Forms;

namespace WorldSkillsRussia2020.admin
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            label1.ForeColor = Color.Green;
            label1.Text = "Вы вошли в аккаунт!";
        }
    }
}
