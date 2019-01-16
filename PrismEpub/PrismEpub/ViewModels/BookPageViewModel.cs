using Prism.Navigation;

namespace PrismEpub.ViewModels
{
    public class BookPageViewModel : ViewModelBase
    {
        public BookPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Book Page";
        }
    }
}