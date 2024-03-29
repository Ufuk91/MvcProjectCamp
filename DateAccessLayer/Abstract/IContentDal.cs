﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessLayer.Abstract
{
    public interface IContentDal : IRepository<Content>
    {
        void Insert(Contact contact);
        void Delete(object contact);
        void Update(Contact contact);
    }
}
