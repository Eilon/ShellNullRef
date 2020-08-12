using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XF = Xamarin.Forms;

namespace ShellNullRef
{
    public class AppShell : Xamarin.Forms.Shell
    {
        private readonly ShellContentMarkerItem _dummyShellContent = new ShellContentMarkerItem();

        public AppShell()
        {
            Items.Add(_dummyShellContent);

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

                //var didRemove = Items.Remove(_dummyShellContent);
            });
        }
    }

    internal sealed class ShellContentMarkerItem : XF.FlyoutItem
    {
        public ShellContentMarkerItem()
        {
            // Set dummy content to ensure the item is valid
            var tab = new XF.Tab();
            tab.Items.Add(new XF.ShellContent
            {
                Content = new XF.ContentPage()
            });
            Items.Add(tab);
        }
    }
}
