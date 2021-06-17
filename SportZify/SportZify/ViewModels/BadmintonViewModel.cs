using SportZify.Models;
using SportZify.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.ViewModels
{
    public class BadmintonViewModel: BaseViewModel
    {
        public List<BadmintonCourt> Courts { get; set; }

        public BadmintonViewModel()
        {
            Courts = new BadmintonService().GetCourtsList();
        }
    }
}
