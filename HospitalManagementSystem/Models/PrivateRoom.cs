﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    class PrivateRoom : Room
    {
       
        public PrivateRoom() : base(Hospital.Config.PrivateRoomCapacity, Hospital.Config.PrivateRoomPrice)
        {
        }
    }

}
