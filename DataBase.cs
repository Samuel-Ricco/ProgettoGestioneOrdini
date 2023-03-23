using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGruppo2
{
    
    public class DataBase
    {
        public db_a967b2_dblogintestEntities ctx = new db_a967b2_dblogintestEntities();


        public List<order> GetOrdersById(int id) { return ctx.orders.Where(x => x.customer_id == id).ToList(); }

        public DbRawSqlQuery<OrderDetail> GetOrderDetails(int id)
        {
            var result = ctx.Database.SqlQuery<OrderDetail>("select so.city as city_store, sf.first_name as staff_name, sf.last_name as staff_surname " +
            "from sales.orders o " +
            "join sales.stores so on so.store_id = o.store_id " +
            "join sales.staffs sf on sf.staff_id = o.staff_id" +
            $" where o.order_id = {id}");

            return result;
        }

        public DbRawSqlQuery<OrderItems> GetOrderItems(int id)
        {
            var result = ctx.Database.SqlQuery<OrderItems>("select production.products.product_name, sales.order_items.quantity, sales.order_items.list_price " +
            "from sales.orders " +
            "join sales.order_items on sales.order_items.order_id = sales.orders.order_id " +
            "join production.products on production.products.product_id = sales.order_items.product_id " +
            $"where sales.orders.order_id = {id}");

            return result;
        }


        public class OrderItems
        {
            public string product_name { get; set; }
            public int quantity { get; set; }
            public decimal list_price { get; set; }
        }

        public class OrderDetail
        {
            public string city_store { get; set; }
            public string staff_name { get; set; }
            public string staff_surname { get; set; }
        }
    }
}
