using System.Windows.Forms;

namespace yapistir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool stopLoop = false;



        private void startLoop()
        {
            while (!stopLoop)
            {
                string text = textBox1.Text;
                Thread.Sleep(1000);
                SendKeys.SendWait(text);
                Thread.Sleep(1000);
                SendKeys.Send("{ENTER}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            stopLoop = false;
            startLoop();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopLoop = true;
           
        }

        
    }
}