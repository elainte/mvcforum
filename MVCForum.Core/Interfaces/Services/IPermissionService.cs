﻿namespace MvcForum.Core.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using DomainModel.Entities;

    public partial interface IPermissionService
    {
        IEnumerable<Permission> GetAll();
        Permission Add(Permission permission);
        void Delete(Permission permission);
        Permission Get(Guid id);
    }
}