﻿using CQRSPattern.Models;
using MediatR;

namespace CQRSPattern.Command
{
    public class UpdateEmployeeCommand:IRequest<int>
    {
        public UpdateEmployeeCommand(int id,string name, string address, string email, string phone)
        {
           
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
