

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
                using (var olustur = File.CreateText(Application.StartupPath + "/eczanem.txt"))
                {

                    olustur.WriteLine($"ECZANE BÝLGÝLERÝM---------{txtEczaneAdi.Text} ECZANESÝ");
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            // TextBox'larýn deðerini al
                            string textBoxValue = ctrl.Text;
                            if (textBoxValue != null & textBoxValue != "")
                            {
                                olustur.WriteLine($"{textBoxValue}");
                            }

                        }
                    }
                }
                MessageBox.Show("Kaydedildi");
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sifre sifre = new Sifre();
            sifre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIts.UseSystemPasswordChar = true;
            txtItsSifre.UseSystemPasswordChar = true;
            txtSgkSicil.UseSystemPasswordChar = true;
            ttxtSgkSifre.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            BenimEczanemContext benimEczanemContext  =new BenimEczanemContext();
            il il=new il();
            ilDal ilDal = new ilDal();
            cmbIl.DataSource = ilDal.SehirListele();
            cmbIl.DisplayMember= "Name";
            cmbIl.ValueMember = "Id";
        }
    }
}
