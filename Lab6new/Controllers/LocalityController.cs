﻿using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class LocalityController:CRUDCardController<Locality>
    {
        public LocalityController(IPermissionManager permissionManager, User user)
        {
            User = user;
            PermissionManager = permissionManager;
        }

        private User User { get; }

        public IPermissionManager PermissionManager { get; }

        public bool Validate(string locality)
        {
            return GetLocalities(new List<Predicate<Locality>> { (x) => x.Locality1 == locality },(x)=>true).FirstOrDefault() != null;
        }
        public List<Locality> GetLocalities(List<Predicate<Locality>> filters, Func<Locality, object> sort)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.LocalityReadFilter);
            return GetData(resultFilter.GlueFilters(), sort).ToList();
        }

        public List<Locality> GetData(Predicate<Locality> filter, Func<Locality, object> sort)
        {
            using (var db = new Lab3newContext())
            {
                return db.Localities
                    .Include(x => x.District)
                    .AsEnumerable()
                    .Where(x => filter(x))
                    .OrderBy(sort)
                    .AsQueryable()
                    .ToList();
            }
        }

    }
}
