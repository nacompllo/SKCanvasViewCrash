using SKCanvasViewCrash.Controls;

namespace SKCanvasViewCrash;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        IDispatcherTimer timer;

        timer = Dispatcher.CreateTimer();
        timer.IsRepeating = true;
        timer.Interval = TimeSpan.FromMilliseconds(500);
        timer.Tick += (s, e) =>
        {
            AddProgress(bar1, 10);
        };
        timer.Start();
    }

    void AddProgress(CircularProgressBar view, double add)
    {
        var value = view.Progress + add;

        if (value > 100)
            value = 0;

        view.Progress = value;
    }
}