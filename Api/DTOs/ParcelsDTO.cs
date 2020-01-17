using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Api.Enums;

namespace Api.DTOs
{
    public class ParcelsDTO
    {
        public List<Parcel> StorePlaces { get; set; }
        public CollectionGetStatus Status;
    }
}
