﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Data
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}