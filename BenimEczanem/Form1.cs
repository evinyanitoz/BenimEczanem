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

                    olustur.WriteLine($"ECZANE BÝLGÝLERÝM---------{txtEczaneAdi.Text} ECZANESÝ");
                    foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        // TextBox'larýn deðerini al
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
