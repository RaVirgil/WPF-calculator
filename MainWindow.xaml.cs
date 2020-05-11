using System.Windows;
using System.Windows.Controls;

namespace MVP_Tema1
{

    public partial class MainWindow : Window
    {
        Equation equation = new Equation();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText(btnOne.Content.ToString());
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText(btnTwo.Content.ToString());
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText(btnThree.Content.ToString());
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText("4");
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText("5");
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText("6");
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText("7");
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText("8");
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText("9");
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtInput.AppendText("0");
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

            txtInput.Text = Utils.AddOperand(txtInput.Text, " + ");
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = Utils.AddOperand(txtInput.Text, " - ");
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = Utils.AddOperand(txtInput.Text, " * ");
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = Utils.AddOperand(txtInput.Text, " / ");
        }

        private void btnPow_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = Utils.AddOperand(txtInput.Text, " ^ ");
        }

        private void btnMP_Click(object sender, RoutedEventArgs e)
        {
            equation.IncrementMemory(txtOutput.Text);
            txtM.Text = equation.GetMemoryToString();
        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            equation.ResetMemory();
            txtM.Text = equation.GetMemoryToString();
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            equation.CalculateExpression(txtInput.Text);
            txtOutput.Text = equation.GetExpression();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = Utils.ClearText(txtInput.Text);
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mnitmAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow next = new AboutWindow();
            next.Show();
        }

        private void mnitmCopyEquation_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtInput.Text);
        }

        private void mnitmCutEquation_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtInput.Text);
            txtInput.Clear();
        }

        private void mnitmPasteEquation_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.AppendText(Clipboard.GetText());
        }
    }
}


