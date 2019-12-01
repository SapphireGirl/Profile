using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(Configuration config)
        {

        }
        public string BannerUrl { get; set; }
    }
}
