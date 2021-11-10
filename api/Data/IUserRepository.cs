﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Entities;

namespace api.Data
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
    }
}