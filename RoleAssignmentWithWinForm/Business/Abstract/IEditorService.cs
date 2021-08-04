using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEditorService
    {
        List<Editor> GetAll();
        void Add(Editor editor);
        void Update(Editor editor);
        void Delete(Editor editor);
    }
}
