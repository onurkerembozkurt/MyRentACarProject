﻿using Core.Entities;

namespace Entity.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}
