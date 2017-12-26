﻿namespace Badge.Photogenic
{
    using MvcForum.Core.DomainModel.Attributes;
    using MvcForum.Core.DomainModel.Entities;
    using MvcForum.Core.Interfaces.Badges;

    [Id("1931b389-b2b1-481c-80fc-03f1900e113d")]
    [Name("Photogenic")]
    [DisplayName("Badge.Photogenic.Name")]
    [Description("Badge.Photogenic.Desc")]
    [Image("photogenic.png")]
    [AwardsPoints(20)]
    public class Photogenic : IProfileBadge
    {
        public bool Rule(MembershipUser user)
        {
            return !string.IsNullOrEmpty(user.Avatar);
        }
    }
}