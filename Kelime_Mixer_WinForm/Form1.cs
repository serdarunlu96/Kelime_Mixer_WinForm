namespace Kelime_Mixer_WinForm
{
    public partial class Form1 : Form
    {
        List<string> kelimeler = new List<string>();
        public Form1()
        {
            InitializeComponent();
            try
            {
                string[] kaydedilenler = File.ReadAllLines("kelimeler.txt");
                kelimeler.AddRange(kaydedilenler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
            }
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kelime = txtKelime.Text.Trim();

            if (kelime == "")
                return;

            kelimeler.Add(kelime);
            Listele();
            txtKelime.Clear();
        }

        private void Listele()
        {
            lstKelimeler.Items.Clear();
            foreach (string kelime in kelimeler)
            {
                lstKelimeler.Items.Add(kelime);
            }
        }

        private void lstKelimeler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstKelimeler.SelectedIndex > -1)
            {
                kelimeler.RemoveAt(lstKelimeler.SelectedIndex);
                Listele();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines("kelimeler.txt", kelimeler);
        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            string kelime = lstKelimeler.SelectedItem.ToString();

            if (kelime == "")
                return;

            kelimeler.Remove(kelime);
            Listele();
            txtKelime.Clear();
    }
    }
}