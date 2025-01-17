﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Components;

namespace Blazor.Pages.Cards
{
    public partial class ItemsCard
    {
        private IList<Inventory> _inventories;

        [Parameter]
        public int LocationId { set; get; }

        protected override async Task OnInitializedAsync()
        {
            _inventories = await _inventoryHandler.GetAllByLocationIdAsync(LocationId);
        }
    }
}