﻿/**
* 
* Project SmartBlazor
* Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
* This software is licensed under MIT License. See LICENSE.
* 
**/

using System.Threading.Tasks;

namespace SmartBlazor.Service;

public interface ILocalStorageService
{
    Task<T?> GetItem<T>(string key);
    Task RemoveItem(string key);
    Task SetItem<T>(string key, T value);
}
