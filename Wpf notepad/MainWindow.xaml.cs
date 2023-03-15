using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_notepad
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.CheckPathExists.ToString();
                FilePathTextBox.Text = openFileDialog.FileName;
                FileContentsTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void cutText_Click(object sender, RoutedEventArgs e)
        {
            FileContentsTextBox.Cut();
        }

        private void copyText_Click(object sender, RoutedEventArgs e)
        {
            FileContentsTextBox.Copy();
        }

        private void pastText_Click(object sender, RoutedEventArgs e)
        {
            FileContentsTextBox.Paste();
        }

        private void selectAllText_Click(object sender, RoutedEventArgs e)
        {
            FileContentsTextBox.SelectAll();
        }
    }
}
