﻿using System;
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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentProjectPath;
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Welcome to my Program!", "Hello!");
            currentProjectPath = Directory.GetCurrentDirectory().ToString();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            //unchecking checkboxes
            this.BacherlorCheckBox.IsChecked = this.HighCheckBox.IsChecked = this.JuniorCheckBox.IsChecked = this.MScCheckBox.IsChecked =
                this.PHDCheckBox.IsChecked = this.PrimaryCheckBox.IsChecked = false;

            //reseting textboxes
            this.NoteTextBox.Text = this.OthersTextBox.Text = this.SavedTextBox.Text = "";
            this.OthersTextBox.IsReadOnly = true;
            this.SavedTextBox.Visibility = Visibility.Hidden;
            this.SavedTextBlock.Visibility = Visibility.Hidden;

            //reseting combobox
            this.UniversityComboBox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void PrimaryCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.BacherlorCheckBox.IsChecked = this.HighCheckBox.IsChecked = this.JuniorCheckBox.IsChecked =
                this.MScCheckBox.IsChecked = this.PHDCheckBox.IsChecked = false;
        }

        private void JuniorCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.BacherlorCheckBox.IsChecked = this.HighCheckBox.IsChecked = this.PrimaryCheckBox.IsChecked =
                this.MScCheckBox.IsChecked = this.PHDCheckBox.IsChecked = false;
        }

        private void HighCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.BacherlorCheckBox.IsChecked = this.PrimaryCheckBox.IsChecked = this.JuniorCheckBox.IsChecked =
                this.MScCheckBox.IsChecked = this.PHDCheckBox.IsChecked = false;
        }

        private void BacherlorCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.PrimaryCheckBox.IsChecked = this.HighCheckBox.IsChecked = this.JuniorCheckBox.IsChecked =
                this.MScCheckBox.IsChecked = this.PHDCheckBox.IsChecked = false;
        }

        private void MScCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.BacherlorCheckBox.IsChecked = this.HighCheckBox.IsChecked = this.JuniorCheckBox.IsChecked =
                this.PrimaryCheckBox.IsChecked = this.PHDCheckBox.IsChecked = false;
        }

        private void PHDCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.BacherlorCheckBox.IsChecked = this.HighCheckBox.IsChecked = this.JuniorCheckBox.IsChecked =
                this.MScCheckBox.IsChecked = this.PrimaryCheckBox.IsChecked = false;
        }
    }
}
