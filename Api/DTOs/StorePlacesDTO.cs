using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Api.Enums;

namespace Api.DTOs
{
    public class StorePlacesDTO
    {
        public List<StorePlace> StorePlaces { get; set; }
        public CollectionGetStatus Status;
    }
}
