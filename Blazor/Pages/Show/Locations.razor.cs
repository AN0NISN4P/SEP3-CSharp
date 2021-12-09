﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Pages.Cards;
using Entities.Models;
using Radzen;

namespace Blazor.Pages.Show
{
    public partial class Locations
    {
        private IList<ItemLocation> _itemLocations;

        string pagingSummaryFormat = "Displaying page {0} of {1} (total {2} records)";
        bool showPagerSummary = true;
    
        protected override async Task OnInitializedAsync()
        {
            _itemLocations = await _itemLocationHandler.GetAllAsync();

            DialogService.OnOpen += Open;
            DialogService.OnClose += Close;
        }

        async Task OpenItemWithLocations(ItemLocation itemLocation)
        {
            await DialogService.OpenAsync<ItemsCard>($"Location: {itemLocation.Location.Description}",
                new Dictionary<string, object>() {{"ItemLocation", itemLocation}},
                new DialogOptions() {Width = "1000px", Height = "530px"});
        }

        void Open(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
        {
            Console.WriteLine("Dialog Opened");
        }

        void Close(dynamic result)
        {
            Console.WriteLine("Dialog closed");
        }
    }
}