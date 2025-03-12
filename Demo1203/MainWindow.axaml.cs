using Avalonia.Controls;
using Demo1203.Models;

namespace Demo1203;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        foreach (User user in Utils.Context.users)
        {
            if (LoginTextBox.Text == user.Login && PasswordTextBox.Text == user.Password)
            {
                ProductsListWindow productsListWindow = new();
                productsListWindow.Show();
                Close();
            }
        }
    }

    private void LoginAsGuestButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ProductsListWindow productsListWindow = new();
        productsListWindow.Show();
        Close();
    }
}