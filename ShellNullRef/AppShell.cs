using Xamarin.Forms;

namespace ShellNullRef
{
    public class AppShell : Xamarin.Forms.Shell
    {
        private static bool UseDummyShellItem = true;

        private readonly ShellContentMarkerItem _dummyShellContent = new ShellContentMarkerItem();

        public AppShell()
        {
            if (UseDummyShellItem)
            {
                Items.Add(_dummyShellContent);
            }

            Device.InvokeOnMainThreadAsync(() =>
            {
                var shellContent = new ShellContent
                {
                    Title = "I am shell content.",
                    Content = new ContentPage
                    {
                        Title = "I am page content.",
                        Content = new Label
                        {
                            Text = "I am a label.",
                        },
                    }
                };
                Items.Add(shellContent);

                if (UseDummyShellItem)
                {
                    var didRemove = Items.Remove(_dummyShellContent);
                }
            });
        }
    }

    internal sealed class ShellContentMarkerItem : FlyoutItem
    {
        public ShellContentMarkerItem()
        {
            // Set dummy content to ensure the item is valid
            var tab = new Tab();
            tab.Items.Add(new ShellContent
            {
                Content = new ContentPage()
            });
            Items.Add(tab);
        }
    }
}
