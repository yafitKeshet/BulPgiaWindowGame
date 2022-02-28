using System;
using System.Windows.Forms;

namespace Ex05.BoolPgia.UI
{

    public partial class SetupForm : Form
    {

        private int k_MaxAllowedChances = 10;
        private int k_MinAllowedChances = 4;
        private int m_CurrentNumOfChances = 4;

        public SetupForm()
        {
            InitializeComponent();
        }

        public int CurrentNumOfChances
        {
            get
            {
                return m_CurrentNumOfChances;
            }
        }

        private void buttonStart_Click(object i_Sender,EventArgs i_E)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void setupForm_Load(object i_Sender, EventArgs i_E)
        {

        }

        private void buttonNumOfChances_Click(object i_Sender, EventArgs i_E)
        {
            m_CurrentNumOfChances = m_CurrentNumOfChances == k_MaxAllowedChances ? k_MinAllowedChances : m_CurrentNumOfChances + 1;

            buttonNumOfChances.Text = @"Number of chances: " + m_CurrentNumOfChances;
        }
    }
}
