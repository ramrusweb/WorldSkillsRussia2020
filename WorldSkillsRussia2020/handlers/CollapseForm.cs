using System.Windows.Forms;

namespace WorldSkillsRussia2020.handlers
{
    class CollapseForm : Form
    {
        // Свернуть форму.
        internal void collapseForm ()
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
