/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/


namespace SmartBlazor.Data;


public class TodoItem
{
    public TodoItem()
    {
        this.Title = "";
    }

    public string Title { get; set; }
    public bool IsDone { get; set; }
}

