using System;
using System.Collections.Generic;

namespace TurnerDevChallenge.Data.ViewModels
{
    public class TitleViewModel : ViewModelBase
    {
        public string TitleName { get; set; }
        public string ReleaseYear { get; set; }

        public string StoryLine { get; set; }

        public string Genre { get; set; }

        public IList<AwardViewModel> Awards { get; set; }

        public IList<ParticipantViewModel> Participants { get; set; }

    }
}
