using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Api.Services;

namespace Api.Controllers
{
    public class SortController
    {
        private readonly ISortService _sortService;

        public SortController(ISortService sortService)
        {
            _sortService = sortService;
        }

        public List<Parcel> Sort(List<Parcel> parcelsToSort)
        {
            return null;
        }
    }
}
