using System.Windows.Forms;

namespace NotiSender
{
    public partial class Form1 : Form
    {
        private NotifyIcon notication;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Null";
            string contents = "Null";
            title = textBox1.Text;
            contents = textBox2.Text;
            notication = new NotifyIcon();
            notication.Icon = SystemIcons.Information;
            notication.Visible = true;
            notication.BalloonTipTitle = title;
            notication.BalloonTipText = contents;
            notication.BalloonTipIcon = ToolTipIcon.Info;
            notication.ShowBalloonTip(3000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = "Null";
            string contents = "Null";
            title = textBox1.Text;
            contents = textBox2.Text;
            notication = new NotifyIcon();
            notication.Icon = SystemIcons.Information;
            notication.Visible = true;
            notication.BalloonTipTitle = title;
            notication.BalloonTipText = contents;
            notication.BalloonTipIcon = ToolTipIcon.Info;
            notication.ShowBalloonTip(3000);
            while (true)
                {
                    notication.ShowBalloonTip(3000);
                Task.Delay(1500);
                }

            
        }
    }
}
