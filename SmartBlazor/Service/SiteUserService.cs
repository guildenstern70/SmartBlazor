/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using SmartBlazor.Data;

namespace SmartBlazor.Service;

public class SiteUserService : ISiteUserService
{

    private readonly List<SiteUser> users = new()
    {
        new SiteUser("guest", "guest"),
        new SiteUser("alessio", "doctor")
    };

    public bool IsUsernameAvailable(string username)
    {
        return this.GetUser(username) == null;
    }

    public bool CheckLogin(string username, string password)
    {
        var user = this.GetUser(username);
        if (user == null)
            return false;
        if (user.Password.Equals(password))
        {
            return true;
        }
        return false;
    }

    public SiteUser? GetUser(string username)
    {
        return this.users.FirstOrDefault(x => x.Username == username);
    }

    public void AddUser(string username, string password)
    {
        this.users.Add(new SiteUser(username, password));
    }

}

