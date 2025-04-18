using CS_DemoSerialization.Models.Demographics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;

namespace CS_DemoSerialization
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void btnBinarySerialize_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                DOB = DateTime.Parse(txtDateOfBirth.Text)
            };

            FileStream fs = new FileStream("Person.bin",
                FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, p);
                MessageBox.Show("Data serialized");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
                fs.Dispose();
            }
        }

        private void btnBinaryDeserialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Person.bin",
                FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                Person p = formatter.Deserialize(fs) as Person;
                MessageBox.Show("Data deserialized");
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtDateOfBirth.Text = p.DOB.ToString();
                txtAge.Text = p.Age.ToString();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
                fs.Dispose();
            }
        }

        private void btnXmlSerialize_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                DOB = DateTime.Parse(txtDateOfBirth.Text)
            };

            FileStream fs = new FileStream("Person.xml",
                FileMode.Create, FileAccess.Write);
            XmlSerializer formatter =
                new XmlSerializer(typeof(Person));
            try
            {
                formatter.Serialize(fs, p);
                MessageBox.Show("Data serialized");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
                fs.Dispose();
            }
        }

        private void btnXmlDeserialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Person.xml",
                FileMode.Open, FileAccess.Read);
            XmlSerializer formatter =
                new XmlSerializer(typeof(Person));
            try
            {
                Person p = formatter.Deserialize(fs) as Person;
                MessageBox.Show("Data deserialized");
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtDateOfBirth.Text = p.DOB.ToString();
                txtAge.Text = p.Age.ToString();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
                fs.Dispose();
            }
        }

        private void btnJsonSerialize_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                DOB = DateTime.Parse(txtDateOfBirth.Text)
            };

            FileStream fs = new FileStream("Person.json",
                FileMode.Create, FileAccess.Write);
            StreamWriter writer= new StreamWriter(fs);
            
            try
            {
                writer.Write(JsonSerializer.Serialize(p));
                MessageBox.Show("Data serialized");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer.Close();
                writer.Dispose();
                fs.Close();
                fs.Dispose();
            }
        }

        private void btnJsonDeserialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Person.json",
                FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            try
            {
                string data= reader.ReadToEnd();
                Person p = 
                    JsonSerializer.Deserialize<Person>(data);
                MessageBox.Show("Data deserialized");
                txtId.Text = p?.Id.ToString();
                txtName.Text = p?.Name;
                txtDateOfBirth.Text = p?.DOB.ToString();
                txtAge.Text = p?.Age.ToString();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
                fs.Dispose();
            }
        }
    }
}
