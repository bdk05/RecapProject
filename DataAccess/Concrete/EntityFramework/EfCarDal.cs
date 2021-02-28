using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal

    {
        /*  public void Add(Car entity)
          {
              using (RecapContext context=new RecapContext())
              {

                  var addedEntity = context.Entry(entity);
                  addedEntity.State = EntityState.Added;
                  context.SaveChanges();

               }
          }

          public void Delete(Car entity)
          {
              using (RecapContext context = new RecapContext())
              {
                  var deletedEntity = context.Entry(entity);
                  deletedEntity.State = EntityState.Deleted;
                  context.SaveChanges();

              }
          }

          public Car Get(Expression<Func<Car, bool>> filter)
          {
              using (RecapContext context = new RecapContext())
              {
                  return context.Set<Car>().SingleOrDefault(filter);

              }

          }


          public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
          {
              using (RecapContext context = new RecapContext())
              {
                  return filter == null
                      ? context.Set<Car>().ToList()
                      : context.Set<Car>().Where(filter).ToList();

              }
          }


          public void Update(Car entity)
          {
              using (RecapContext context = new RecapContext())
              {
                  var modifiedEntity = context.Entry(entity);
                  modifiedEntity.State = EntityState.Modified;
                  context.SaveChanges();

              }
          }*/
        public List<CarDetailsDto> GetCarDetails()
        {
            using (RecapContext context=new RecapContext())
            {
                var result=from c in context.Cars
                           join co in context.Colors
                           on c.ColorId equals co.ColorId
                           select new CarDetailsDto
                           {
                               Id = c.Id,
                               //ColorId=co.ColorId,
                               ColorName=co.ColorName,
                               //ModelYear=c.ModelYear,
                               DailyPrice=c.DailyPrice,
                               Description=c.Description

                           };
                return result.ToList();

            }
        }
    }
}
