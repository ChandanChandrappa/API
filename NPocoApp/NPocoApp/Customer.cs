﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPoco;

namespace NPocoApp
{

    [TableName("Customers")]
    [PrimaryKey("CustomerId")]
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCountry { get; set; }
    }
}
