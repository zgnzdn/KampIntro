﻿using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concretes
{
    class StarbucksCustomerManager:BaseCustomerManager  
    {

        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            base.Save(customer);
            else
            {
                throw new Exception("Not a valid Person");
            }
        }
    }
}
