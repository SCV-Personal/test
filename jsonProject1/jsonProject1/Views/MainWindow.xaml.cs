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
using jsonProject1.ViewModels;
using jsonProject1.Views;
using Newtonsoft.Json;

namespace jsonProject1
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

        #region UI Elements
        private void btnDeserialize_Click(object sender, RoutedEventArgs e)
        {
            // Take inputted text and push to output textbox
            // textBoxOutput.Text = textBoxInput.Text;
            // Call funciton
            desrializeJSON(textBoxInput.Text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Clear output text
            textBoxOutput.Text = string.Empty;
        }
        #endregion

        #region JSON Function
        private void desrializeJSON(string strJSON)
        {
            try
            {
                // Establish Variable
                var jSON = JsonConvert.DeserializeObject<Class1>(strJSON);
                textBoxOutput.Text = jSON.name.ToString();
            } catch (Exception ex)
            {
                textBoxOutput.Text = ("Error" + ex.Message.ToString());
            }
        }


        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
        }
    }
}
