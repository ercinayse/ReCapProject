using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var addedColor = reCapContext.Entry(entity);
                addedColor.State = EntityState.Added;
                reCapContext.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var deletedColor = reCapContext.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                reCapContext.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                return reCapContext.Set<Color>().SingleOrDefault(filter);

            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                return filter == null ? reCapContext.Set<Color>().ToList() : reCapContext.Set<Color>().Where(filter).ToList();

            }
        }

        public void Update(Color entity)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var updatedColor = reCapContext.Entry(entity);
                updatedColor.State = EntityState.Deleted;
                reCapContext.SaveChanges();
            }
        }
    }
}
