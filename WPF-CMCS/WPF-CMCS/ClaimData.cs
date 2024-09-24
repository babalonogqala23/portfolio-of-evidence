using System.Collections.ObjectModel;

namespace WPF_CMCS
{
    public static class ClaimData
    {
        public static ObservableCollection<Claim> Claims { get; } = new ObservableCollection<Claim>();
    }
}