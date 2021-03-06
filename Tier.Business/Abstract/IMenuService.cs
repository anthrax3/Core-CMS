﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;

namespace Tier.Business.Abstract
{
   public interface IMenuService
    {
        List<Menu> GetAll();
        List<Menu> GetAllByType(MenuType type);
        void Add(Menu menu);
        void Update(Menu menu);
        void Delete(int menuId);
        Menu GetById(int menuId);
    }
}
