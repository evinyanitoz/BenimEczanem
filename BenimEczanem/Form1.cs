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
            olustur.WriteLine($"Eczane Adý:{txtEczaneAdi.Text} Tckn:{txtTckn.Text}" +
                $"Eczane  Adý:{txtAdi.Text} Soyadý:{txtSoyadi.Text} Adres: {txtAdres.Text}" +
                $"Ýlçesi: Ýli: Vergi Dairesi:{txtVergiDairesi.Text} Vergi No:{txtVergiNo.Text}" +
                $"Oda Sicili:{txtOdaSicili.Text} Bölgesi: {txtBolgesi.Text}");
            olustur.Close();
            MessageBox.Show("Kaydedildi");
        }
    }
}
