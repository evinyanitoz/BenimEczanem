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
            var olustur = File.CreateText(Application.StartupPath+ "/eczanem.txt");
            olustur.WriteLine($"Eczane Ad�:{txtEczaneAdi.Text} Tckn:{txtTckn.Text}" +
                $"Eczane  Ad�:{txtAdi.Text} Soyad�:{txtSoyadi.Text} Adres: {txtAdres.Text}" +
                $"�l�esi: �li: Vergi Dairesi:{txtVergiDairesi.Text} Vergi No:{txtVergiNo.Text}" +
                $"Oda Sicili:{txtOdaSicili.Text} B�lgesi: {txtBolgesi.Text}");
            olustur.Close();
            MessageBox.Show("Kaydedildi");
        }
    }
}
