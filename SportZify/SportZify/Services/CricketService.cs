using SportZify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.Services
{
    public class CricketService
    {
        public List<CricketClub> GetCricketClubs()
        {
            return new List<CricketClub>()
            {
                new CricketClub()
                {
                    ClubId=1,
                    ClubName="Rangers Club",
                    ClubCity="Bhilai",
                    ClubLocation="Sector-1",
                    ClubCharge=130,
                    ClubImageURL="https://total-play.co.uk/wp-content/uploads/2017/11/New-total-play-ECB-approved-artificial-cricket-practice-nets-at-Furness-CC-300x225.jpg",
                    ClubVideoURL="https://www.youtube.com/embed/YLS1GoBdtvk",
                    ClubContact=8888877777,
                    GameName="Cricket"
                },
                new CricketClub()
                {
                    ClubId=2,
                    ClubName="Sports Paradise",
                    ClubCity="Bhilai",
                    ClubLocation="Sector-9",
                    ClubCharge=190,
                    ClubImageURL="https://img1.exportersindia.com/product_images/bc-full/2019/6/6009980/practice-cricket-net-1560420284-4950255.jpeg",
                    ClubVideoURL="https://www.youtube.com/embed/YLS1GoBdtvk",
                    ClubContact=8888877777,
                    GameName="Cricket"
                },
                new CricketClub()
                {
                    ClubId=3,
                    ClubName="Lions Club",
                    ClubCity="Bhilai",
                    ClubLocation="Sector-5",
                    ClubCharge=190,
                    ClubImageURL="https://i.pinimg.com/originals/c1/a2/b8/c1a2b8beb71cfc6f00b8404e50a9f429.jpg",
                    ClubVideoURL="https://www.youtube.com/embed/YLS1GoBdtvk",
                    ClubContact=8888877777,
                    GameName="Cricket"
                },
                new CricketClub()
                {
                    ClubId=4,
                    ClubName="Community Ground",
                    ClubCity="Bhilai",
                    ClubLocation="Sector-2",
                    ClubCharge=180,
                    ClubImageURL="https://total-play.co.uk/wp-content/uploads/2015/12/ql-botany.jpg",
                    ClubVideoURL="https://www.youtube.com/embed/YLS1GoBdtvk",
                    ClubContact=8888877777,
                    GameName="Cricket"
                },
                new CricketClub()
                {
                    ClubId=5,
                    ClubName="Jayanti Stadium",
                    ClubCity="Bhilai",
                    ClubLocation="Maroda",
                    ClubCharge=200,
                    ClubImageURL="https://www.chainlinkfencing.org/images/cricket-enclosure.jpg",
                    ClubVideoURL="https://www.youtube.com/embed/YLS1GoBdtvk",
                    ClubContact=8888877777,
                    GameName="Cricket"
                },
            };
        }
    }
}
