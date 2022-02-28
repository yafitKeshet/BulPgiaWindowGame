namespace Ex05.BoolPgia.Logic
{
    public struct SequenceAndFeedback
    {
        private string m_Sequence;
        private string m_Feedback;

        public SequenceAndFeedback(string i_Sequence, string i_Feedback)
        {
            m_Sequence = i_Sequence;
            m_Feedback = i_Feedback;
        }

        public string Sequence
        {
            get
            {
                return m_Sequence;
            }
            set
            {

                m_Sequence = value;
            }
        }

        public string Feedback
        {
            get
            {
                return m_Feedback;
            }
            set
            {
                m_Feedback = value;
            }
        }

    }
}