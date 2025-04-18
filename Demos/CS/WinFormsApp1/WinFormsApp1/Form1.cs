using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileOk += (s, e) => 
            {
                //MessageBox.Show(ofd.FileName);
                Assembly asm = Assembly.LoadFile(ofd.FileName);
                if (asm != null)
                {
                    //MessageBox.Show(asm.FullName);
                    Type[] types= asm.GetTypes();
                    //MessageBox.Show(types.Length.ToString());
                    foreach (Type t in types)
                    {
                        //MessageBox.Show(t.FullName);
                        label1.Text = t.Name;
                    }
                }
            };
            ofd.Title = "Browse & select target assembly";
            ofd.ShowDialog();
        }
    }
}
