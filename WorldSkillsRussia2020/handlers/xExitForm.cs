using System;
using System.Windows.Forms;

namespace WorldSkillsRussia2020.handlers
{
    class xExitForm : Form
    {
        internal void xExitMeth()
        {
            if (MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Предупреждение!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                base.Dispose();
            }
        }
    }
}
