using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace bolekLolek;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void PersonComboBox_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var person = (personComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();
        string imagePath = person switch
        {
            "Bolek" => "avares://bolekLolek/Assets/bolek.webp",
            "Lolek" => "avares://bolekLolek/Assets/lolek.webp"
        };
        var uri = new Uri(imagePath);
        using var stream = AssetLoader.Open(uri);
        personImage.Source = new Bitmap(stream);
    }

    private void AddButton_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void DeleteButton_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void SummaryButton_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}