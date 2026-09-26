using Microsoft.EntityFrameworkCore;
using Task10.Data;
using Task10.Models;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-List all customers' first and last names along with their email addresses.
            ApplicationDbContext _context = new ApplicationDbContext();
            //var FirstName=_context.Customers.AsQueryable().FirstOrDefault();
            //Console.WriteLine($"First Customer Id:{FirstName.CustomerId},Name:{FirstName.FirstName}, Customer email:{FirstName.Email}");
            //var LastName = _context.Customers.AsQueryable().OrderBy(i=>i.CustomerId).LastOrDefault();
            //Console.WriteLine($"Last Customer Id:{LastName.CustomerId},Name:{LastName.FirstName}, Customer email:{LastName.Email}");

            //2- Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).
            //var Spec_order = _context.Orders.AsQueryable().Where(s => s.StaffId == 3);
            //foreach (var order in Spec_order) {
            //    Console.WriteLine($"Order Id:{order.OrderId},Order Date:{order.OrderDate},Store Id:{order.StoreId},Order Status:{order.OrderStatus},Staff Id:{order.StaffId}");
            //}

            //3- Get all products that belong to a category named "Mountain Bikes". 
            //var Products = _context.Products.AsQueryable().Join(
            //    _context.Categories.AsQueryable(),
            //    p => p.CategoryId,
            //    c => c.CategoryId,
            //    (p, c) => new
            //    {
            //        p.ProductId,
            //        p.ProductName,
            //        c.CategoryName
            //    }
            //    ).Where (o=>o.CategoryName== "Mountain Bikes")
            //    .Select(c=>new
            //    {
            //        c.ProductId,
            //        c.ProductName,
            //        c.CategoryName
            //    }
            //    );
            //foreach (var product in Products)
            //{
            //    Console.WriteLine($"Product Id:{product.ProductId},Product Name:{product.ProductName},Category Name:{product.CategoryName}");
            //}

            //. 4-Count the total number of orders per store. 
            //var OrderCount = _context.Orders.GroupBy(c => c.StoreId).Select(e => new
            //{
            //    e.Key,
            //    orderCount = e.Count(),
            //});

            //foreach (var item in OrderCount)
            //{
            //    Console.WriteLine($"{item.Key} , {item.orderCount}");
            //}

            //5- List all orders that have not been shipped yet (shipped_date is null).
            //var NotShipped = _context.Orders.AsQueryable().Where(a => a.ShippedDate == null);
            //foreach (var order in NotShipped)
            //{
            //    Console.WriteLine($"{order.OrderId},{order.CustomerId},{order.OrderStatus},{order.ShippedDate}");
            //}

            //6- Display each customer’s full name and the number of orders they have placed. 
            //var Customers = _context.Customers.GroupJoin(
            // _context.Orders,
            // c => c.CustomerId,
            // o => o.CustomerId,
            // (c, o) => new{ 
            //  FullName = c.FirstName + " " + c.LastName,
            //  OrderCount = o.Count()
            //  }).AsQueryable();

            //foreach (var customer in Customers)
            //{
            //    Console.WriteLine($"{customer.FullName},{customer.OrderCount}");
            //}

            //7- List all products that have never been ordered (not found in order_items). 
            //var NotFound = _context.Products.GroupJoin(
            // _context.OrderItems,
            // p => p.ProductId,
            // o => o.ProductId,
            // (p, o) => new
            // {
            //     p.ProductId,
            //     OrderCount = o.Count()
            // }).AsQueryable().Where(c => c.OrderCount == 0);
            //foreach (var item in NotFound) {
            //    Console.WriteLine($"{item.ProductId},{item.OrderCount}");
            //}

            //8- Display products that have a quantity of less than 5 in any store stock. 
            //var ProductWithStock = _context.Stocks.AsQueryable().Where(s => s.Quantity < 5).Include(p => p.Product);

            //foreach (var item in ProductWithStock)
            //{
            //    Console.WriteLine($"{item.ProductId},{item.Product.ProductName},{item.Quantity}");
            //}

            //9- Retrieve the first product from the products table.
            //var FirstProduct = _context.Products.AsQueryable().FirstOrDefault();

            //10- Retrieve all products from the products table with a certain model year.
            //var ModelYearProducts = _context.Products.AsQueryable().Where(p => p.ModelYear == 2016);
            //foreach (var product in ModelYearProducts)
            //{
            //    Console.WriteLine($"Product Id:{product.ProductId},Product Name:{product.ProductName},Model Year:{product.ModelYear}");
            //}

            //11- Display each product with the number of times it was ordered. 
            //var ProductOrderCount = _context.Products.GroupJoin(
            // _context.OrderItems,
            // p => p.ProductId,
            // o => o.ProductId,
            // (p, o) => new
            // {
            //     p.ProductId,
            //     p.ProductName,
            //     OrderCount = o.Count()
            // }).AsQueryable();
            //foreach (var item in ProductOrderCount)
            //{
            //    Console.WriteLine($"{item.ProductId},{item.ProductName},{item.OrderCount}");
            //}

            //12- Count the number of products in a specific category. 
            //var productCount = _context.Products.AsQueryable().GroupBy(p => p.CategoryId).Select(g => new
            //{
            //    CategoryId = g.Key,
            //    Count = g.Count()
            //}).Where(c=>c.CategoryId == 1);
            //foreach (var item in productCount)
            //{
            //    Console.WriteLine($"Category Id:{item.CategoryId},Product Count:{item.Count}");
            //}

            //13- Calculate the average list price of products.
            //var AvgProductPrice = _context.Products.AsQueryable().Average(p => p.ListPrice);
            //Console.WriteLine($"Average Product Price:{AvgProductPrice}");

            //14- Retrieve a specific product from the products table by ID. 
            //var SpecificProduct = _context.Products.Find(10);
            //Console.WriteLine($"Product Id:{SpecificProduct.ProductId},Product Name:{SpecificProduct.ProductName},Model Year:{SpecificProduct.ModelYear},List Price:{SpecificProduct.ListPrice}");

            //15- List all products that were ordered with a quantity greater than 3 in any order. 
            // var ProductsWithQuantity = _context.Stocks.AsQueryable().Where(o => o.Quantity > 3).Include(p => p.Product).OrderBy(p => p.Product.ProductId);
            //foreach (var product in ProductsWithQuantity)
            //{
            //    Console.WriteLine($"Product Id:{product.ProductId},Product Name:{product.Product.ProductName},Quantity:{product.Quantity}");
            //}

            //16- Display each staff member’s name and how many orders they processed.
            //var StaffWithOrders = _context.Staffs.GroupJoin(
            // _context.Orders,
            // s=> s.StaffId,
            // o => o.StaffId,
            // (s, o) => new
            // {
            //     s.StaffId,
            //     OrderCount = o.Count()
            // }).AsQueryable();
            //foreach (var item in StaffWithOrders)
            //{
            //    Console.WriteLine($"{item.StaffId},{item.OrderCount}");
            //}

            //17- List active staff members only (active = true) along with their phone numbers. 
            //var ActiveStaff = _context.Staffs.Where(s=>s.Active==true).Select(s => new
            //{
            //   s.StaffId,
            //   FullName= s.FirstName+ " " +s.LastName,
            //   s.Phone
            //}).AsQueryable();
            //foreach (var staff in ActiveStaff)
            //{
            //    Console.WriteLine($"Staff Id:{staff.StaffId},Full Name:{staff.FullName},Phone:{staff.Phone}");
            //}

            //18- List all products with their brand name and category name.
            //var BrandAndCategory = _context.Products.Include(b => b.Brand).Include(c=>c.Category).Select(o => new
            //{
            //    o.ProductId,
            //    o.Category.CategoryName,
            //    o.Brand.BrandName
            //});
            //foreach (var item in BrandAndCategory)
            //{
            //    Console.WriteLine($"Product Id:{item.ProductId},Category Name:{item.CategoryName},Brand Name:{item.BrandName}");
            //}

            //19 - Retrieve orders that are completed
            //var Orders = _context.Orders.AsQueryable().Where(o => o.ShippedDate == null);
            //foreach (var order in Orders)
            //{

            //        Console.WriteLine($"Order Id:{order.OrderId},Order Date:{order.OrderDate},Store Id:{order.StoreId},Order Status:{order.OrderStatus},Staff Id:{order.StaffId}");
            // }

            //20- List each product with the total quantity sold (sum of quantity from order_items).
            //var ProductsWithQuantity = _context.Stocks.AsQueryable().Include(p => p.Product).GroupBy(s => s.ProductId).Select(g => new
            //{
            //    ProductId = g.Key,
                
            //    Quantity = g.Sum(s => s.Quantity)
            //}).OrderBy(p => p.ProductId);
            //foreach (var product in ProductsWithQuantity)
            //{
            //    Console.WriteLine($"Product Id:{product.ProductId},Quantity:{product.Quantity}");
            //}

        }
    }
}
