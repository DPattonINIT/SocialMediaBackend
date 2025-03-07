using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaBackend.Model
{
    public class SocialModel
    {
        public string? Platform { get; set; }
        public string? User { get; set; }
        public int Followers { get; set; }
        public int FollowerGrowth { get; set; }
        public int PageViews { get; set; }
        public int PageViewsGrowth { get; set; }
        public int Retweets { get; set; }
        public int RewtweetsGrowth { get; set; }
        public int Likes { get; set; }
        public int LikesGrowth { get; set; }
        public int ProfileViews { get; set; }
        public int ProfileViewsGrowth { get; set; }
        public int TotalViews { get; set; }
        public int TotalViewsGrowth { get; set; }
        public int Subscribers { get; set; }
        public int SubscribersGrowth { get; set; }
        public string? Image { get; set; }
    }
}