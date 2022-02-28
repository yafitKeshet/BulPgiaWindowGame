using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex05.BoolPgia.UI
{
    public partial class ColorsForm : Form
    {
        private Color m_ChosenColor = Color.Empty;
        private string m_ColorName = string.Empty;

        public Color ChosenColor
        {
            get { return m_ChosenColor; }
        }

        public string ColorName
        {
            get
            {
                return m_ColorName;
            }
        }

        public ColorsForm()
        {
            InitializeComponent();
        }

        private void button_Click(object i_Sender, EventArgs i_E)
        {
            m_ChosenColor = (i_Sender as Button).BackColor;
            m_ColorName = (i_Sender as Button).Name;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void colorsForm_Load(object i_Sender, EventArgs i_E)
        {

        }
    }
}
