﻿using System.Collections.Generic;
using Aurora.Domain.Entities;
using Aurora.Domain.Interfaces;

namespace Aurora.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User, int>, IRepositoryUser
    {
        public void Remove(int id) =>
            base.Delete(id);


        public void Save(User obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj);
        }

        public User GetById(int id) =>
            base.Select(id);

        public IList<User> GetAll() =>
            base.Select();

    }
}
