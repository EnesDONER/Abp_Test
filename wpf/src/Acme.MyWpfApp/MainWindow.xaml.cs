using System;
using System.Windows;

namespace Acme.MyWpfApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly HelloWorldService _helloWorldService;
    private readonly SumService _sumService;

    public MainWindow(HelloWorldService helloWorldService, SumService sumService)
    {
        _helloWorldService = helloWorldService;
        _sumService = sumService;
        InitializeComponent();
    }

    protected override void OnContentRendered(EventArgs e)
    {
        HelloLabel.Content = _helloWorldService.SayHello();
        SumResultLabel.Content = _sumService.Sum(3,5);
    }
}
