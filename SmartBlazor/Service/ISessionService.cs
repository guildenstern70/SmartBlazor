/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using System.Threading.Tasks;

namespace SmartBlazor.Service;

public interface ISessionService
{
    Task<string?> GetLoggedUser();
    Task Login(string username);
    void Logout();
}
