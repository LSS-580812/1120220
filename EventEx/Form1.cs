namespace EventEx
{
    public partial class Form1 : Form
    {
        private MyCalss obj;

        public Form1()
        {
            InitializeComponent();
            obj = new MyCalss();
            obj.XChanged += Obj_XChanged;
        }

        private void Obj_XChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{obj.eventText} X 的值改變了{obj.X}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            obj.X += 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            obj.eventText = btn.Text;
            obj.X += 1;
            
        }
    }

    public class MyCalss
    {
        public event EventHandler XChanged;
        private void OnXChanged()
        {
            if (XChanged != null)
            {
                XChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    OnXChanged();
                }
            }
        }
        public string eventText { get; set; } = "";
    }

}