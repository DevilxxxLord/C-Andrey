namespace FirstApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ���������� ������� �� ������
        /// </summary>
        /// <param name="sender">�������� �������</param>
        /// <param name="e">��������� �������</param>
        private void button_Click(object sender, EventArgs e)
        {
            // ���������� ���� � ������
            Button button = (Button)sender;
            // �������������� ������ � �����
            int n = int.Parse(button.Text);
            // ���������� �����
            n = n + 1;
            // ���� ����� ������, ��� 9
            if (n > 9)
            {
                n = 1; // ������� � �������
            }
            // ����������� ����� ������� � ������
            button.Text = n.ToString();

            // ��������� ��� ������ � ������ ����� ����
            foreach (Button b1 in Controls)
            {
                b1.BackColor = Color.Gray;
            }

            // ������� ���� ������
            foreach (Button b1 in Controls)
            {
                // ��� ������ ������ ���������� ��� ��������� ������
                foreach (Button b2 in Controls)
                {
                    // �� ���� ��������� ������ � ��� �� �����
                    if (b1 == b2) continue;

                    // ���� ����� �� ������� ���������, ���������� ������ ������
                    if (b1.Text == b2.Text)
                    {
                        b2.BackColor = Color.Coral;
                    }
                }
            }
        }
    }
}
