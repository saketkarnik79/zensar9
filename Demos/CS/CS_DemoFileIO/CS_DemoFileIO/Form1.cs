using System.IO;

namespace CS_DemoFileIO
{
    public partial class frmFiles : Form
    {
        public frmFiles()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Data.bin",
                FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            try
            {
                bw.Write(txtData.Text);
                //bw.Flush();//Push data to the stream
                MessageBox.Show("File written successfully.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Sorry nahi ho paya write.\n" +
                    $"{ex.Message}");
            }
            finally
            {
                bw.Close();
                fs.Close();
                bw.Dispose();
                fs.Dispose();
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Data.bin",
                FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            try
            {
                string data = string.Empty;
                while (br.PeekChar() >= 0)
                {
                    data += Convert.ToChar(br.Read());
                }
                MessageBox.Show("File read successfully.");
                txtData.Text = data;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Sorry nahi ho paya read.\n" +
                    $"{ex.Message}");
            }
            finally
            {
                br.Close();
                fs.Close();
                br.Dispose();
                fs.Dispose();
            }
        }

        private void btnTextWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Data.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            try
            {
                sw.WriteLine(txtData.Text);
                //sw.Flush();//Push data to the stream
                MessageBox.Show("File written successfully.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Sorry nahi ho paya write.\n" +
                    $"{ex.Message}");
            }
            finally
            {
                sw.Close();
                fs.Close();
                sw.Dispose();
                fs.Dispose();
            }
        }

        private void btnTextRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Data.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            try
            {
                string data = sr.ReadToEnd();
                MessageBox.Show("File read successfully.");
                txtData.Text = data;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Sorry nahi ho paya read.\n" +
                    $"{ex.Message}");
            }
            finally
            {
                sr.Close();
                fs.Close();
                sr.Dispose();
                fs.Dispose();
            }
        }
    }
}
