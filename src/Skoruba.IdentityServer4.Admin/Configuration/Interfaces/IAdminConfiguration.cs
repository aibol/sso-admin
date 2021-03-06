﻿namespace Skoruba.IdentityServer4.Admin.Configuration.Interfaces
{
    public interface IAdminConfiguration
    {
        string IdentityAdminRedirectUri { get; }

        string IdentityServerBaseUrl { get; }

        string IdentityAdminBaseUrl { get; }

        string AdminUserName { get; }

        string AdminPassword { get; }

        string AdminEmail { get; }
    }
}