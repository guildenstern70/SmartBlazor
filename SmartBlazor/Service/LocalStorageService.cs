/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022-23 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using Microsoft.JSInterop;
using System.Text.Json;

namespace SmartBlazor.Service;


/**
* This class manages client-side local storage in the browser
**/
public class LocalStorageService : ILocalStorageService
{
    private readonly IJSRuntime _jsRuntime;

    public LocalStorageService(IJSRuntime jsRuntime)
    {
        this._jsRuntime = jsRuntime;
    }

    public async Task<T?> GetItem<T>(string key)
    {
        string? json = await this._jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
        
        // This is true before login
        if (json == null)
            return default;

        return JsonSerializer.Deserialize<T>(json);
    }

    public async Task SetItem<T>(string key, T value)
    {
        await this._jsRuntime.InvokeVoidAsync("localStorage.setItem", key, 
            JsonSerializer.Serialize(value));
    }

    public async Task RemoveItem(string key)
    {
        await this._jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
    }
}

