﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryApp.Models
{
    public class UserAim
    {
        public int User_Id { get; set; }
        public string Aim { get; set; }
        public string Description { get; set; }
        

        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }



    }
}