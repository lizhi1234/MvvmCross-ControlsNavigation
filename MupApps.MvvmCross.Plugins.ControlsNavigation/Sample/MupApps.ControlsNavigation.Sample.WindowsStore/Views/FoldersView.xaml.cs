using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Cirrious.MvvmCross.WindowsStore.Views;
using MupApps.ControlsNavigation.Sample.Core.ViewModels;

namespace MupApps.ControlsNavigation.Sample.WindowsStore.Views
{
    public sealed partial class FoldersView : MvxStorePage
    {
        public FoldersView()
        {
            this.InitializeComponent();
        }

        private void FoldersView_OnLoaded(object sender, RoutedEventArgs e)
        {
            //As the folder is also showed on this view, we don't wait for the user to select one
            ((FoldersViewModel)ViewModel).SelectedFolder = ((FoldersViewModel)ViewModel).Folders.FirstOrDefault();
        }
    }
}
