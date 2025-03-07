using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaBackend.Model;

namespace SocialMediaBackend.Services
{
    public class SocialMediaService
    {
        public ContainerModel GetSocialData()
        {
            var containModel = new ContainerModel();

            containModel.Platforms.Add(new SocialModel
            {
                Platform = "Facebook",
                User = "@nathanf",
                Followers = 1987,
                FollowerGrowth = 12,
                PageViews = 87,
                PageViewsGrowth = 3,
                Likes = 52,
                LikesGrowth = 2,
                Image = "/assets/icon-facebook.svg"
            });
            containModel.Platforms.Add(new SocialModel
            {
                Platform = "Twitter",
                User = "@nathanf",
                Followers = 1044,
                FollowerGrowth = 99,
                Retweets = 117,
                RewtweetsGrowth = 303,
                Likes = 507,
                LikesGrowth = 553,
                Image = "/assets/icon-twitter.svg"
            });
            containModel.Platforms.Add(new SocialModel
            {
                Platform = "Instagram",
                User = "@realnathanf",
                Followers = 11,
                FollowerGrowth = 99,
                Likes = 5462,
                LikesGrowth = 2257,
                ProfileViews = 52,
                ProfileViewsGrowth = 1375,
                Image = "/assets/icon-instagram.svg"
            });
            containModel.Platforms.Add(new SocialModel
            {
                Platform = "Youtube",
                User = "Nathan F.",
                Subscribers = 8239,
                SubscribersGrowth = 144,
                Likes = 107,
                LikesGrowth = 19,
                TotalViews = 1407,
                TotalViewsGrowth = 12,
                Image = "/assets/icon-youtube.svg"
            });

            return containModel;
        }
    }
}