﻿using RestaurantAPI.Models;
using System.Collections.Generic;

namespace RestaurantAPI.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        IEnumerable<RestaurantDto> GetAll();
        RestaurantDto GetById(int id);
        void Delete(int id);
        RestaurantDto Edit(int id, EditRestaurantDto editRestaurantDto);
    }
}