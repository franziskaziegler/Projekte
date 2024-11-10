namespace Projekt_Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zahl1_Click(object sender, EventArgs e)
        {
            Input.AppendText("1");
        }

        private void Zahl2_Click(object sender, EventArgs e)
        {
            Input.AppendText("2");
        }

        private void Zahl3_Click(object sender, EventArgs e)
        {
            Input.AppendText("3");
        }

        private void Zahl4_Click(object sender, EventArgs e)
        {
            Input.AppendText("4");
        }

        private void Zahl5_Click(object sender, EventArgs e)
        {
            Input.AppendText("5");
        }

        private void Zahl6_Click(object sender, EventArgs e)
        {
            Input.AppendText("6");
        }

        private void Zahl7_Click(object sender, EventArgs e)
        {
            Input.AppendText("7");
        }

        private void Zahl8_Click(object sender, EventArgs e)
        {
            Input.AppendText("8");
        }

        private void Zahl9_Click(object sender, EventArgs e)
        {
            Input.AppendText("9");
        }

        private void Zahl0_Click(object sender, EventArgs e)
        {
            Input.AppendText("0");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            var inputText = Input.Text;
            var inputLength = inputText.Length;

            if (inputLength > 0)
            {
                Input.Text = inputText.Remove(inputLength - 1);
            }


        }

        private void komma_Click(object sender, EventArgs e)
        {
            if (!Input.Text.Contains(","))
            {
                Input.AppendText(",");
            }
        }

        private void Multiplizieren_Click(object sender, EventArgs e)
        {
            if (!Input.Text.Contains("*"))
            {
                Input.AppendText("*");
            }

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (!Input.Text.Contains("-"))
            {
                Input.AppendText("-");
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (!Input.Text.Contains("+"))
            {
                Input.AppendText("+");
            }
        }

        private void IstGleich_Click(object sender, EventArgs e)
        {
            if (Input.Text.Contains("*"))
            {
                string[] zahlen = Input.Text.Split("*");
                float zahl1 = float.Parse(zahlen[0]);
                float zahl2 = float.Parse(zahlen[1]);

                float ergebnis = zahl1 * zahl2;
                Input.Text = ergebnis.ToString();
            }

            if (Input.Text.Contains("-"))
            {
                string[] zahlen = Input.Text.Split("-");
                float zahl1 = float.Parse(zahlen[0]);
                float zahl2 = float.Parse(zahlen[1]);

                float ergebnis = zahl1 - zahl2;
                Input.Text = ergebnis.ToString();
            }

            if (Input.Text.Contains("+"))
            {
                string[] zahlen = Input.Text.Split("+");
                float zahl1 = float.Parse(zahlen[0]);
                float zahl2 = float.Parse(zahlen[1]);

                float ergebnis = zahl1 + zahl2;
                Input.Text = ergebnis.ToString();
            }
        }
    }       
}
