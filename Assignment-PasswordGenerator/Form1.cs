using System.Text;


namespace Assignment_PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sifreUzunlugu;
        int sifreSayisi;

        const string kucukHarf = "abcdefghijklmnopqrstuvwxyz";
        const string buyukHarf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string rakamlar = "123456789";
        const string ozelKarakter = "*$-+?_&=!%{}/";
        const string kucukBuyukHarf = kucukHarf + buyukHarf;
        const string kucukRakam = kucukHarf + rakamlar;
        const string kucukOzel = kucukHarf + ozelKarakter;
        const string kucukBuyukRakam = kucukHarf + buyukHarf + rakamlar;
        const string kucukBuyukOzel = kucukHarf + ozelKarakter + buyukHarf;
        const string kucukRakamOzel = kucukHarf + rakamlar + ozelKarakter;
        const string kucukBuyukOzelRakam = kucukHarf + ozelKarakter + buyukHarf + rakamlar;
        const string buyukRakam = buyukHarf + rakamlar;
        const string buyukOzel = buyukHarf + ozelKarakter;
        const string buyukOzelRakam = buyukHarf + ozelKarakter + rakamlar;
        const string rakamOzel = rakamlar + ozelKarakter;

        public void PasswordGenerator(string parametreler)
        {

            sifreSayisi = int.Parse(numSifreSayisi.Value.ToString());

            StringBuilder password = new StringBuilder();
            Random rnd = new Random();

            for (int i = 1; i <= sifreSayisi; i++)
            {
                sifreUzunlugu = int.Parse(numSifreUzunlugu.Value.ToString());
                while (0 < sifreUzunlugu)
                {
                    password.Append(parametreler[rnd.Next(parametreler.Length)]);
                    sifreUzunlugu--;
                }
                lbSifreler.Items.Add($"{i}-) {password}");
                password.Clear();
            }

        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            lbSifreler.Items.Clear();
            if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == false && chkRakam.Checked == false && chkOzelKarakter.Checked == false)
            {
                PasswordGenerator(kucukHarf);
            }

            else if (chkKucukKarakter.Checked == false && chkBuyukKarakter.Checked == true && chkRakam.Checked == false && chkOzelKarakter.Checked == false)
            {
                PasswordGenerator(buyukHarf);
            }

            else if (chkKucukKarakter.Checked == false && chkBuyukKarakter.Checked == false && chkRakam.Checked == true && chkOzelKarakter.Checked == false)
            {
                PasswordGenerator(rakamlar);
            }

            else if (chkKucukKarakter.Checked == false && chkBuyukKarakter.Checked == false && chkRakam.Checked == false && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(ozelKarakter);
            }

            else if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == true && chkRakam.Checked == false && chkOzelKarakter.Checked == false)
            {
                PasswordGenerator(kucukBuyukHarf);
            }

            else if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == false && chkRakam.Checked == true && chkOzelKarakter.Checked == false)
            {
                PasswordGenerator(kucukRakam);
            }

            else if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == false && chkRakam.Checked == false && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(kucukOzel);
            }

            else if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == true && chkRakam.Checked == true && chkOzelKarakter.Checked == false)
            {
                PasswordGenerator(kucukBuyukRakam);
            }

            else if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == true && chkRakam.Checked == false && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(kucukBuyukOzel);
            }

            else if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == false && chkRakam.Checked == true && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(kucukRakamOzel);
            }

            else if (chkKucukKarakter.Checked == true && chkBuyukKarakter.Checked == true && chkRakam.Checked == true && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(kucukBuyukOzelRakam);
            }

            else if (chkKucukKarakter.Checked == false && chkBuyukKarakter.Checked == true && chkRakam.Checked == true && chkOzelKarakter.Checked == false)
            {
                PasswordGenerator(buyukRakam);
            }

            else if (chkKucukKarakter.Checked == false && chkBuyukKarakter.Checked == true && chkRakam.Checked == true && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(buyukOzelRakam);
            }

            else if (chkKucukKarakter.Checked == false && chkBuyukKarakter.Checked == true && chkRakam.Checked == false && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(buyukOzel);
            }

            else if (chkKucukKarakter.Checked == false && chkBuyukKarakter.Checked == false && chkRakam.Checked == true && chkOzelKarakter.Checked == true)
            {
                PasswordGenerator(rakamOzel);
            }
            else
            {
                MessageBox.Show("Lutfen en az bir adet parametre seciniz.");
            }

        }

    }
}