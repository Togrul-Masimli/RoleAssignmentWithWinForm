using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EditorManager : IEditorService
    {
        IEditorDal _editorDal;
        public EditorManager(IEditorDal editorDal)
        {
            _editorDal = editorDal;
        }
        public void Add(Editor editor)
        {
            _editorDal.Add(editor);
        }

        public void Delete(Editor editor)
        {
            _editorDal.Delete(editor);
        }

        public List<Editor> GetAll()
        {
            return _editorDal.GetAll();
        }

        public void Update(Editor editor)
        {
            _editorDal.Update(editor);
        }
    }
}
