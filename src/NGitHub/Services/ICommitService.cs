﻿using System;
using System.Collections.Generic;
using NGitHub.Models;
using NGitHub.Web;

namespace NGitHub.Services {
    public interface ICommitService {
        GitHubRequestAsyncHandle GetCommitAsync(string user,
                                                string repo,
                                                string sha,
                                                Action<Commit> callback,
                                                Action<GitHubException> onError);
        GitHubRequestAsyncHandle GetCommitsAsync(string user,
                                                 string repo,
                                                 string branch,
                                                 int page,
                                                 Action<IEnumerable<Commit>> callback,
                                                 Action<GitHubException> onError);
    }
}
