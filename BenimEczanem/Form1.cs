namespace BenimEczanem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (var olustur = File.CreateText(Application.StartupPath + "/eczanem.txt")) {

                    olustur.WriteLine($"ECZANE B�LG�LER�M---------{txtEczaneAdi.Text} ECZANES�");
                    foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        // TextBox'lar�n de�erini al
                        string textBoxValue = ctrl.Text;
                            if(textBoxValue!=null &  textBoxValue != "") { 
                        olustur.WriteLine($"{textBoxValue}");
                            }

                        }
                }
            }
                MessageBox.Show("Kaydedildi");
            }
            catch { }
        
        }
    }
}
