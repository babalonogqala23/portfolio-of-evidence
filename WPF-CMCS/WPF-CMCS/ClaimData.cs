using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    using System.Collections.ObjectModel;

    namespace WPF_CMCS
    {
        public static class ClaimData
        {
            public static ObservableCollection<Claim> Claims { get; } = new ObservableCollection<Claim>();
        }
    }

