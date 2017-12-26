﻿namespace MvcForum.Core.Events
{
    using Interfaces.UnitOfWork;

    public class LoginEventArgs : MVCForumEventArgs
    {
        public string ReturnUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public IUnitOfWork UnitOfWork { get; set; }
    }
}