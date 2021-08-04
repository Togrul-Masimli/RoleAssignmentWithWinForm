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
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            using (RoleAssignmentContext context = new RoleAssignmentContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Customer entity)
        {
            using (RoleAssignmentContext context = new RoleAssignmentContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (RoleAssignmentContext context = new RoleAssignmentContext())
            {
                return filter == null
                    ? context.Set<Customer>().ToList()
                    : context.Set<Customer>().Where(filter).ToList();
            }
        }

        public void Update(Customer entity)
        {
            using (RoleAssignmentContext context = new RoleAssignmentContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
