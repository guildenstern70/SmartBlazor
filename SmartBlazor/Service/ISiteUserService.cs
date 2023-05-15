/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022-23 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using SmartBlazor.Data;
using SmartBlazor.Data.Model;

namespace SmartBlazor.Service;

public interface ISiteUserService
{
    void AddUser(string username, string password);
    SiteUser? GetUser(string username);
    bool IsUsernameAvailable(string username);
    bool CheckLogin(string username, string password);
}


