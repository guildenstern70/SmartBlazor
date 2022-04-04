/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBlazor.Data.Model;

public class WeatherForecast
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public void SetTemperature(char scale, int measure)
    {
        if (scale is 'f' or 'F')
        {
            this.TemperatureC = 5/9 * (measure-32);
        }
        else
        {
            this.TemperatureC = measure;
        }
    }
}
