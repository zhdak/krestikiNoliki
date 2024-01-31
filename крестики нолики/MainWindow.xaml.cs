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

namespace крестики_нолики
{
    public partial class MainWindow : Window
    {
        string[] buttons = new string[9] { "button1", "button2", "button3", "button4", "button5", "button6", "button7", "button8", "button9"};
        string namebutton;
        int index;
        int rndnum;
        int count;
        Random rndm = new Random();
        bool chtobibotnexodil = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void robocop()
        {
            if (chtobibotnexodil == false) 
            {
                count = buttons.Count(word => word == "не робит");
                if (count < 9)
                {
                    rndnum = rndm.Next(0, 8);
                    while (buttons[rndnum] == "не робит")
                    {
                        rndnum = rndm.Next(0, 8);
                    }
                    if (rndnum == 0)
                    {
                        button1.Content = "0";
                        button1.IsEnabled = false;
                        buttons[0] = "не робит";
                    }
                    else if (rndnum == 1)
                    {
                        button2.Content = "0";
                        button2.IsEnabled = false;
                        buttons[1] = "не робит";
                    }
                    else if (rndnum == 2)
                    {
                        button3.Content = "0";
                        button3.IsEnabled = false;
                        buttons[2] = "не робит";
                    }
                    else if (rndnum == 3)
                    {
                        button4.Content = "0";
                        button4.IsEnabled = false;
                        buttons[3] = "не робит";
                    }
                    else if (rndnum == 4)
                    {
                        button5.Content = "0";
                        button5.IsEnabled = false;
                        buttons[4] = "не робит";
                    }
                    else if (rndnum == 5)
                    {
                        button6.Content = "0";
                        button6.IsEnabled = false;
                        buttons[5] = "не робит";
                    }
                    else if (rndnum == 6)
                    {
                        button7.Content = "0";
                        button7.IsEnabled = false;
                        buttons[6] = "не робит";
                    }
                    else if (rndnum == 7)
                    {
                        button8.Content = "0";
                        button8.IsEnabled = false;
                        buttons[7] = "не робит";
                    }
                    else if (rndnum == 8)
                    {
                        button9.Content = "0";
                        button9.IsEnabled = false;
                        buttons[8] = "не робит";
                    }
                }
                else
                {
                    MessageBox.Show("Ничья!");
                    chtobibotnexodil = true;
                    Clear();
                }
                CheckWin();
            }
        }
        public void CheckWin()
        {
            if (button1.Content == "X" && button2.Content == "X" 
                && button3.Content == "X" || button4.Content == "X"
                && button5.Content == "X" && button6.Content == "X"
                || button7.Content == "X" && button8.Content == "X"
                && button9.Content == "X" ||button1.Content == "X"
                && button5.Content == "X" && button9.Content == "X"
                || button3.Content == "X" && button5.Content == "X"
                && button7.Content == "X" || button1.Content == "X"
                && button4.Content == "X" && button7.Content == "X"
                || button2.Content == "X" && button5.Content == "X"
                && button8.Content == "X" || button3.Content == "X"
                && button6.Content == "X" && button9.Content == "X")
            {
                MessageBox.Show("ты победил");
                chtobibotnexodil = true;
                Clear();
            }
            if (button1.Content == "0" && button2.Content == "0"
                && button3.Content == "0" || button4.Content == "0" 
                && button5.Content == "0" && button6.Content == "0" 
                || button7.Content == "0" && button8.Content == "0"
                && button9.Content == "0" || button1.Content == "0"
                && button5.Content == "0" && button9.Content == "0"
                || button3.Content == "0" && button5.Content == "0"
                && button7.Content == "0" || button1.Content == "0"
                && button4.Content == "0" && button7.Content == "0" 
                || button2.Content == "0" && button5.Content == "0"
                && button8.Content == "0" || button3.Content == "0"
                && button6.Content == "0" && button9.Content == "0")
            {
                MessageBox.Show("Победил робокоп");
                chtobibotnexodil = true;
                Clear();
            }
        }
        public void Clear()
        {
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
            buttons[0] = "button1";
            buttons[1] = "button2";
            buttons[2] = "button3";
            buttons[3] = "button4";
            buttons[4] = "button5";
            buttons[5] = "button6";
            buttons[6] = "button7";
            buttons[7] = "button8";
            buttons[8] = "button9";
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;
            chtobibotnexodil = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            chtobibotnexodil = false;
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            namebutton = (sender as Button).Name;
            index = Array.IndexOf(buttons, namebutton);
            buttons[index] = "не робит";
            CheckWin();
            robocop();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
        }
    }
}