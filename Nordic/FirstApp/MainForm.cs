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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            // �������������� ������ � �����
            int n = int.Parse(button2.Text);
            // ���������� �����
            n = n + 1;
            // ���� ����� ������, ��� 9
            if (n > 9)
            {
                n = 1; // ������� � �������
            }
            // ����������� ����� ������� � ������
            button2.Text = n.ToString();
        }       
    }
}
