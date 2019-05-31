using Xamarin.Forms;

namespace CustomRendererTest
{
    public class CustomView : View
    {
    }

    public class App : Application
    {
        public App()
        {
            var rootPage = new ContentPage();
            var navigationPage = new NavigationPage(rootPage);
            var button = new Button()
            {
                Text = "Click me",
                Command = new Command(() => navigationPage.PushAsync(new ContentPage()
                {
                    Content = new CustomView()
                }))
            };
            var content = new StackLayout();
            content.Children.Add(button);
            content.Children.Add(new CustomView());
            rootPage.Content = content;
            this.MainPage = navigationPage;
        }
    }
}
