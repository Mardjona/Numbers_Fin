using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using Avalonia;
using Avalonia.Markup.Xaml;

namespace Numbers;

public partial class MainWindow : Window 
{
   
    public MainWindow()
    {
        InitializeComponent();
    }
    public void ButtonClickedYes(object sender, RoutedEventArgs args)
    {
        
    }
    public void ButtonClickedNo(object sender, RoutedEventArgs args)
    {
        Random random = new Random();
        int p = 9;
        int l = random.Next(100000000, 999999999);
      //  int s = random.Next(0, 9);

      TextBlockNum.Text = Convert.ToString(p) + Convert.ToString(l); //+ Convert.ToString(s);
    }
}


