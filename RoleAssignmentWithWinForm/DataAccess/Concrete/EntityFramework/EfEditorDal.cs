using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEditorDal : IEditorDal
    {
        public void Add(Editor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Editor entity)
        {
            throw new NotImplementedException();
        }

        public List<Editor> GetAll(Expression<Func<Editor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Editor entity)
        {
            throw new NotImplementedException();
        }
    }
}
