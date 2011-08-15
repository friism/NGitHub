﻿using System;
using System.Collections.Generic;
using NGitHub.Models;

namespace NGitHub {
    public interface IFeedService {
        void GetUserActivityAsync(string user,
                                  Action<IEnumerable<FeedItem>> callback,
                                  Action<GitHubException> onError);
        void GetUserNewsFeedAsync(string user,
                                  Action<IEnumerable<FeedItem>> callback,
                                  Action<GitHubException> onError);
    }
}