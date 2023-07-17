using RestaurantAPI.Models;
using System;
using System.Collections.Generic;

namespace RestaurantAPI.Services
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}