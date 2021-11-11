/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using SmartBlazor.Data;

namespace SmartBlazor.Service
{
    public class SiteUserService
    {
        private readonly List<SiteUser> users = new()
        {
            new SiteUser("guest", "guest"),
            new SiteUser("alessio", "doctor")
        };


        public SiteUser? GetUser(string username)
        {
            return this.users.FirstOrDefault(x => x.Username == username);
        }

        public void AddUser(string username, string password)
        {
            this.users.Add(new SiteUser(username, password));
        }

    }
}
