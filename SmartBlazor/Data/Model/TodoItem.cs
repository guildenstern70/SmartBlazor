﻿/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022-23 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/


namespace SmartBlazor.Data.Model;


public class TodoItem
{
    public TodoItem()
    {
        this.Title = "";
    }

    public string Title { get; set; }
    public bool IsDone { get; set; }
}

