using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class HighlightManager : IHighlightService
    {
        private readonly IHighlightDal _highlightDal;

        public HighlightManager(IHighlightDal highlightDal)
        {
            _highlightDal = highlightDal;
        }

        public void TAdd(Highlight entity)
        {
            _highlightDal.Add(entity);
        }

        public void TDelete(Highlight entity)
        {
            _highlightDal.Delete(entity);
        }

        public Highlight TGetByID(int id)
        {
            return _highlightDal.GetById(id);
        }

        public List<Highlight> TGetListAll()
        {
            return _highlightDal.GetAll();
        }

        public void TUpdate(Highlight entity)
        {
            _highlightDal.Update(entity);
        }
    }
}
