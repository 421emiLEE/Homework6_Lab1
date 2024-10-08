using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework6_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void calculationBttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //build in the code
                int operation = listBox.SelectedIndex; //gives different address to operations (0-4 index)
                decimal leftHand = Convert.ToDecimal(left_txt.Text); //convert to decimal before you assign it into the value
                decimal rightHand = Convert.ToDecimal(rightTxt.Text);
                decimal result = 0;
                switch (operation)
                {
                    //operation: addition
                    case 0:
                        result = leftHand + rightHand;
                        resultTxt.Text = result.ToString();
                        break;
                    case 1:
                    //operation subtraction
                        result = leftHand - rightHand;
                        resultTxt.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultTxt.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultTxt.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultTxt.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No operation was selected");
                        break;
                }
            } 
            catch(DivideByZeroException) { MessageBox.Show("Error: Cannot divide by zero!"); }
            //error in the catch
        }
    }
}