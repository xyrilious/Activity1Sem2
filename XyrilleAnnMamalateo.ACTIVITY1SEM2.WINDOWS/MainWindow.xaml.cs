using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XyrilleAnnMamalateo.ACTIVITY1SEM2.WINDOWS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Exam = new List<string> { "english", "science", "mathematics" };
        List<string> Out = new List<string> { };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Exam.Reverse();
            foreach (string exam in Exam) { lbSubmitted.Items.Add(exam); }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            lbSubmitted.Items.Clear();
            Exam.Reverse();
            Exam.Add(txtNew.Text);
            Exam.Reverse();
            foreach (string exam in Exam) { lbSubmitted.Items.Add(exam); }
        }

        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            if (lbSubmitted.SelectedIndex != -1)
            {
                Exam.Remove(lbSubmitted.SelectedItem.ToString());
                lbOutForChecking.Items.Add(lbSubmitted.SelectedItem.ToString());
                Out.Add(lbSubmitted.SelectedItem.ToString());
                lbSubmitted.Items.RemoveAt(lbSubmitted.SelectedIndex);
            }
            else if (lbOutForChecking.SelectedIndex != 1)
            {
                Exam.Reverse();
                Out.Remove(lbOutForChecking.SelectedItem.ToString());
                Exam.Add(lbOutForChecking.SelectedItem.ToString());
                lbOutForChecking.Items.RemoveAt(lbOutForChecking.SelectedIndex);
                Exam.Reverse();
                lbSubmitted.Items.Clear();
                foreach (string exam in Exam) { lbSubmitted.Items.Add(exam); }


            }
            else
            {

            }

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            foreach (string resub in Out)
            {
                Exam.Reverse();
                Exam.Add(resub);
                Exam.Reverse();
            }
            lbSubmitted.Items.Clear();
            foreach (string exam in Exam) { lbSubmitted.Items.Add(exam); }
            lbOutForChecking.Items.Clear();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbSubmitted.SelectedIndex != -1)
            {
                Exam.Remove(lbSubmitted.SelectedItem.ToString());
                lbSubmitted.Items.RemoveAt(lbSubmitted.SelectedIndex);
            }
            else if (lbOutForChecking.SelectedIndex != 1)
            {



            }
            else
            {

            }
        }
    }
}
