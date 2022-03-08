namespace AS2122_4E_INF_Prof_TestGit
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            double operando1 = 0, operando2 = 0, risultato = 0;

            switch (cmbOperatore.Text)
            {
                case "+":
                    operando1 = Convert.ToDouble(txtOperando1.Text);
                    operando2 = Convert.ToDouble(txtOperando2.Text);

                    risultato = operando1 + operando2;
                    break;
                case "-":
                    operando1 = Convert.ToDouble(txtOperando1.Text);
                    operando2 = Convert.ToDouble(txtOperando2.Text);

                    risultato = operando1 - operando2;
                    break;
            }

            lblRisultato.Text = $"Il risultato � {risultato}";

            if (risultato > 0)
                lblRisultato.ForeColor = Color.Green;
            else
                lblRisultato.ForeColor = Color.Red;

        }
    }
}