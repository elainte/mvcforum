﻿namespace MvcForum.Core.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using DomainModel.Entities;

    public partial interface IPostEditService
    {
        void Delete(IList<PostEdit> entity);
        void Delete(PostEdit entity);
        PostEdit Add(PostEdit entity);
        PostEdit Get(Guid id);
        IList<PostEdit> GetByPost(Guid postId);
        IList<PostEdit> GetByMember(Guid memberId);
    }
}