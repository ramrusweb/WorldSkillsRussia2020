using System.Windows.Forms;

namespace WorldSkillsRussia2020.handlers
{
    class MsgBox : Form
    {
        // MessageBox Ошибка.
        internal void errMsgBox(string errmsgbox)
        {
            MessageBox.Show($"{errmsgbox}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // MessageBox Успешно.
        internal void succMsgBox(string succmsgbox)
        {
            MessageBox.Show($"{succmsgbox}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // MessageBox Выход из приложения.
        internal void xExitMsgBox(string xexitmsgbox)
        {
            MessageBox.Show($"{xexitmsgbox}", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}


