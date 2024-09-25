using System.Windows.Forms;

namespace FirstAplicationWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            string message = "Witaj w tym programie\n";

            message += "Ulubione przedmioty:\n";
            if (checkBoxMathematics.Checked ) 
            {
                message += "* Matematyka\n";
            }
            if (checkBoxGerman.Checked)
            {
                message += "* J�zyk niemiecki\n";
            }

            if (radioButtonPizzaYes.Checked ) 
            {
                message += "Lubi� pizze z ananasem\n";
            }
            else
            {
                message += "Nie lubi� pizzy z ananasem\n";
            }

            message += "Twoje imi� to: " + textBoxName.Text + "\n";
            textBoxName.Text = "";

            if (comboBoxFavoriteGame.SelectedIndex != -1 )
            {
                message+="Ulubiona gra to "
                    + comboBoxFavoriteGame.Text + "\n";
            }

            MessageBox.Show(message,
                "Hello",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button2
                );
        }
    }
}
