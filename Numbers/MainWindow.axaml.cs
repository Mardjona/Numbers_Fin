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

    private void InitializeComponent()
    {
        
    }

   
    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Click!");
    }
}


