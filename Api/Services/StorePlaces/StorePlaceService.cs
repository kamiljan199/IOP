using Api.Managers;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Services
{
    public class StorePlaceService : IStorePlaceService
    {
        private readonly IStorePlaceManager _storePlaceManager;
        private readonly IEmployeeManager _employeeManager;
        private readonly IParcelManager _parcelManager;

        public StorePlaceService(IStorePlaceManager storePlaceManager, IEmployeeManager employeeManager, IParcelManager parcelManager)
        {
            _storePlaceManager = storePlaceManager; 
            _employeeManager = employeeManager;
            _parcelManager = parcelManager;
        }

        public StorePlace GetById(int id)
        {
            var storePlace = _storePlaceManager.GetById(id);
            if(storePlace == default(StorePlace))
            {
                throw new Exception($"Store place identified as ${ id } not found.");
            }

            return storePlace;
        }

        public StorePlace GetByIdWithAddress(int id)
        {
            var storePlace = _storePlaceManager.GetByIdWithAddress(id);
            if (storePlace == default(StorePlace))
            {
                throw new Exception($"Store place identified as ${ id } not found.");
            }

            return storePlace;
        }

        public Type GetTypeById(int id)
        {
            var storePlace = GetById(id);
            if(storePlace == default(StorePlace))
            {
                throw new Exception($"Store place identified as ${ id } not found.");
            }


            switch(storePlace.Type)
            {
                case 0:
                    return typeof(Warehouse);

                case 1:
                    return typeof(SendingPoint);
            }

            return typeof(StorePlace);
        }

        public List<StorePlace> GetAll() => _storePlaceManager.GetAll();

        public List<Parcel> GetCouriersParcels(StorePlace storePlace, int courierId)
        {
            var emploee = _employeeManager.GetEmployeeById(courierId);

            if( emploee == null )
            {
                throw new Exception("Emploee of id " + courierId + " not found in database.");
            }

            return _parcelManager.GetParcelsByStorePlace(storePlace).Where( parcel => parcel.CourierID == courierId ).ToList();
        }

        public void AddStoreplace(StorePlace storeplace)
        {
            int result;

            result = _storePlaceManager.AddStoreplace(storeplace);
            
            if(result == 0)
            {
                throw new Exception("Databse wasn't changed");
            }
        }

        public void UpdateStoreplace(StorePlace storeplace)
        {
            int result;

            result = _storePlaceManager.UpdateStoreplace(storeplace);

            if (result == 0)
            {
                throw new Exception("Databse wasn't changed");
            }
        }

        public void RemoveStoreplace(int id)
        {
            int result;

            result = _storePlaceManager.RemoveStoreplace(id);

            if (result == 0)
            {
                throw new Exception("Databse wasn't changed");
            }
        }

        public void ModifyStorePlace(StorePlace editStorePlace)
        {
            var storePlace = _storePlaceManager.GetByIdWithAddress(editStorePlace.Id);
            if(storePlace == default(StorePlace))
            {
                throw new Exception($"Something while editing store place { editStorePlace.Id }.");
            }

            storePlace.Name = editStorePlace.Name;
            storePlace.Type = editStorePlace.Type;

            switch(editStorePlace.Type)
            {
                case 0:
                    (storePlace as Warehouse).ManagerName = (editStorePlace as Warehouse).ManagerName;
                    break;

                case 1:
                    (storePlace as SendingPoint).WorkersCount = (editStorePlace as SendingPoint).WorkersCount;
                    break;
            }

            storePlace.Address.City = editStorePlace.Address.City;
            storePlace.Address.Street = editStorePlace.Address.Street;
            storePlace.Address.PostCode = editStorePlace.Address.PostCode;
            storePlace.Address.HomeNumber = editStorePlace.Address.HomeNumber;
            storePlace.Address.ApartmentNumber = editStorePlace.Address.ApartmentNumber;

            _storePlaceManager.SaveChanges();
        }
    }
}
