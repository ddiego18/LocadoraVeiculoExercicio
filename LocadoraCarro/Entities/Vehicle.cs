using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraCarro.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
