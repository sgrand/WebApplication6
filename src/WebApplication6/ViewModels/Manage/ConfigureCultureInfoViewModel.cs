using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;
using System.Globalization;

public class ConfigureCultureInfoViewModel
{
    public string Culture { get; set; }

    public string UICulture { get; set; } 
    
    public List<SelectListItem> AvailableCultures { get; }

    public ConfigureCultureInfoViewModel()
    {
        AvailableCultures = new List<SelectListItem>
        {
            //new SelectListItem
            //{
            //    Value = "",
            //    Text = "-- Not specified --"
            //},
            new SelectListItem
            {
                Value = new CultureInfo("en").Name,
                Text = new CultureInfo("en").DisplayName
            },
            new SelectListItem
            {
                Value = new CultureInfo("fr").Name,
                Text = new CultureInfo("fr").DisplayName
            },
            //new SelectListItem
            //{
            //    Value = "es",
            //    Text = "Spanish"
            //}
        };
    }
}