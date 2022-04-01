/**
* 
* Project SmartBlazor
* Copyright (C) 2022 Alessio Saltarin 'alessiosaltarin@gmail.com'
* This software is licensed under MIT License. See LICENSE.
* 
**/

namespace SmartBlazor.Service;

public interface ILocalStorageService
{
    Task<T?> GetItem<T>(string key);
    Task RemoveItem(string key);
    Task SetItem<T>(string key, T value);
}
