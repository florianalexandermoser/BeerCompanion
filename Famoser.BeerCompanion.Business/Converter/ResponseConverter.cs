﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Famoser.BeerCompanion.Business.Models;
using Famoser.BeerCompanion.Common.Framework.Singleton;
using Famoser.BeerCompanion.Data.Entities;

namespace Famoser.BeerCompanion.Business.Converter
{
    public class ResponseConverter : SingletonBase<ResponseConverter>
    {
        public DrinkerCycle Convert(DrinkerCycleEntity entity)
        {
            return new DrinkerCycle { Name = entity.Name, Guid = entity.Guid, IsAuthenticated = entity.IsAuthenticated };
        }

        public List<DrinkerCycle> Convert(List<DrinkerCycleEntity> entities)
        {
            if (entities == null)
                return new List<DrinkerCycle>();

            var res = new List<DrinkerCycle>();
            foreach (var drinkerCycleEntity in entities)
            {
                res.Add(Convert(drinkerCycleEntity));
            }
            return res;
        }
        public Drinker Convert(DrinkerEntity entity)
        {
            return new Drinker()
            {
                Name = entity.Name,
                Color = entity.Color,
                TotalBeers = entity.TotalBeers,
                LastBeer = entity.LastBeerTime,
                AuthDrinkerCycleGuids = entity.AuthDrinkerCycles,
                NonAuthDrinkerCycleGuids = entity.NonAuthDrinkerCycles
            };
        }

        public List<Drinker> Convert(List<DrinkerEntity> entities)
        {
            if (entities == null)
                return new List<Drinker>();

            var res = new List<Drinker>();
            foreach (var drinkerEntity in entities)
            {
                res.Add(Convert(drinkerEntity));
            }
            return res;
        }
    }
}
