using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using jsonProject1.ViewModels;
using Newtonsoft.Json;

namespace jsonProject1.Views
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        #region UI Elements
        private void btnDeserialize_Click(object sender, RoutedEventArgs e)
        {
            // Pass Input Text to Output Text
            // textBoxOutput.Text = textBoxInput.Text;
            deserializeJSON(textBoxInput.Text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Empty textbox output
            textBoxOutput.Text = string.Empty;
        }
        #endregion

        #region JSON Function
        private void deserializeJSON(string strJSON)
        {
            try
            {
                // Establish variable
                var jSON = JsonConvert.DeserializeObject<Class1>(strJSON);
                textBoxOutput.Text = jSON.name.ToString();
            } catch (Exception ex)
            {
                textBoxOutput.Text = ("Error : " + ex.Message.ToString());
            }
        }

        #endregion
    }
}
