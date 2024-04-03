using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public EFProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductWithCategories()
        {
             var context = new Context();
                 var values = context.Products.Include(x=>x.Category).ToList();
             return values;
            
        }

        public int ProductCount()
        {
            using var context = new Context();
            return context.Products.Count();
        }
    }
}
