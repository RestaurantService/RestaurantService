﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web;

namespace RestaurantService
{
    
    [Serializable]
    [DataContract]
    public class Restaurant
    {
        [DataMember]
        public string GoogleID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Rating { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}