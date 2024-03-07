﻿using El_Lo2ma_AccessModel.Contexts;
using El_Lo2ma_DomainModel.Interfaces.Auth;
using El_Lo2ma_DomainModel.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Lo2ma_AccessModel.Repositories.Auth
{
    public class UserTypeRepository : BaseRepository<UserType>, IUserTypeRepository
    {
        public UserTypeRepository(Lo2maContext DbCon) : base(DbCon)
        {
        }
    }
}
