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
            return _sortService.Sort(parcelsToSort);
        }

        public void setStorePlace(int placeId)
        {
            _sortService.setStorePlace(placeId);
        }

        public void printGuidelines(string filePath)
        {
            _sortService.PrintGuidelines(filePath);
        }

        public void GetParcelsFromPoints()
        {
            _sortService.GetParcelsFromPoints();
        }

        public void SendParcelsToWarehouses()
        {
            _sortService.SendParcelsToWarehouses();
        }
    }
}
