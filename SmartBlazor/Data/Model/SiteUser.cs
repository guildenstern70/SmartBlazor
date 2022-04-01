/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

namespace SmartBlazor.Data.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SiteUser
{
    public SiteUser()
    {
        this.Username = "";
        this.Password = "";
    }

    public SiteUser(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }
}

