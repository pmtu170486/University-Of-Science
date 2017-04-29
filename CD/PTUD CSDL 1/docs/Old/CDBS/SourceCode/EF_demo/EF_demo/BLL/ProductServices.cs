using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF_demo.DAL;
namespace EF_demo.BLL
{
    class ProductServices
    {
        DAL.demoConnection data = new demoConnection();
        public void create(Product p)
        {
            data.Products.AddObject(p);
            data.SaveChanges();
        }
        public List<Product> findAll()
        {
            // select * from product
            var s = (from p in data.Products
                     select p).ToList<Product>() ;

            return s;
        }
        public void edit(Product p)
        {
            /* Update product set name='new value',
             * price='new value',
             * quantity='new value',
             * supply='new value'
             * where id=id can cap nhat
              * 
            */
            Product a = data.Products.Where(x => x.id == p.id).Single();
            a.name = p.name;
            a.price = p.price;
            a.quantity = p.quantity;
            a.supply = p.supply;
            data.SaveChanges();      
        }
        public void remove(Product p)
        {
            // delete from product where id=id can xoa
            Product a = data.Products.Where(x => x.id == p.id).Single();
            data.Products.DeleteObject(a);
            data.SaveChanges();
        }
        public List<object> findAlls()
        {
            var s = (from p in data.Products
                    from q in data.ProductTypes
                    where p.type == q.id
                    select new
                    {
                        id=p.id,
                        name=p.name,
                        quantity=p.quantity,
                        price=p.price,
                        supply=p.supply,
                        type=q.name
                    }).ToList<object>();
            return s;
        }
    }
}
