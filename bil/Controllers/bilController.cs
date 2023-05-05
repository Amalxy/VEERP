using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using bil.Models;
using Newtonsoft.Json;
namespace bil.Controllers
{
    public class bilController : Controller
    {
        private readonly string connectionString = "Server=LAPTOP-2U5T6AIC\\SQLEXPRESS;Database=model;Trusted_Connection=True;";


        public IActionResult Indoor()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
       
        public ActionResult Register(Shop shop)
        {
            if (ModelState.IsValid)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand("IF OBJECT_ID('Shops', 'U') IS  NULL BEGIN" +
                        " CREATE TABLE Shops (ShopId NVARCHAR(50) , Name NVARCHAR(100) NOT NULL, Address NVARCHAR(200) NOT NULL, Phone NVARCHAR(10) NOT NULL, Email NVARCHAR(100) NOT NULL, Password NVARCHAR(250) NOT NULL); " +
                        "END;", connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    
                    command = new SqlCommand("SELECT * FROM Shops WHERE Name = @Name AND ShopId = @ShopName;", connection);
                    command.Parameters.AddWithValue("@ShopName", shop.Name);
                    command.Parameters.AddWithValue("@Name", shop.Name);

                    SqlDataReader reader = command.ExecuteReader();
                    {
                       // connection.Close();
                        //connection.Close();
                        if (reader.HasRows)
                        {
                            ViewBag.Message = "Hello, world!";
                            return View("ok");  }
                        else
                        {
                            connection.Close();
                            connection.Open();
                            command = new SqlCommand("INSERT INTO Shops (ShopId, Name, Address, Phone, Email, Password) VALUES (@ShopName, @Name, @Address, @Phone, @Email, @Password); ", connection);
                            command.Parameters.AddWithValue("@ShopName", shop.ShopName);
                            command.Parameters.AddWithValue("@Name", shop.Name);
                            command.Parameters.AddWithValue("@Address", shop.Address);
                            command.Parameters.AddWithValue("@Phone", shop.Phone);
                            command.Parameters.AddWithValue("@Email", shop.Email);
                            command.Parameters.AddWithValue("@Password", shop.Password);

                            command.ExecuteNonQuery();
                            connection.Close();

                        }

                    }
                    
                }      

                }
                    return View("Indoor");
        }

        public ActionResult Shops()
        {
            var shops = new List<Shop>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM shops", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var shop = new Shop
                            {
                                ShopName = reader.GetString(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                Phone = reader.GetString(3),
                                Email = reader.GetString(4),
                                Password = reader.GetString(5),
                            };

                            shops.Add(shop);
                        }
                    }
                   
                }
                connection.Close();
            }
            
            return View(shops);
        }

        public ActionResult Login(string name, string shopname, string password)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ShopId FROM Shops WHERE Name = @name and ShopId=@shopname AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@shopname", shopname);
                    command.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //connection.Close();
                        if (reader.HasRows)
                        {
                            String bran = "";
                            // Login successful, redirect to dashboard or other page
                             return RedirectToAction("Invontary", new { name, shopname, bran });

                        }
                        else
                        {
                            // Login failed, show error message
                              ViewBag.Error = "Invalid email or password";
                            return RedirectToAction("Indoor", "bil");
                        }
                    
                    }
                    
                }
            }
        }
        
         public ActionResult Add(string name,string shopname)

        {
            ViewBag.name=name;
            ViewBag.shopname=shopname;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand("IF OBJECT_ID('Products', 'U') IS NULL BEGIN " +
                        "CREATE TABLE Products (name VARCHAR(255), shopname VARCHAR(255), prodectname VARCHAR(255), description VARCHAR(255), category VARCHAR(255), price FLOAT, quantity INT, gst INT, branch VARCHAR(255), supplier VARCHAR(255)) " +
                         "END; " +
                         "INSERT INTO Products (name, shopname, prodectname, description, category, price, quantity, gst, branch, supplier) " +
                                                
                         "VALUES (@name, @shopname, @productname, @description, @category, @price, @quantity, @GST, @branch, @supplier);", connection);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@shopname", product.ShopName);
                    command.Parameters.AddWithValue("@productname", product.ProductName);
                    command.Parameters.AddWithValue("@description", product.Description);
                    command.Parameters.AddWithValue("@category", product.Category);
                    command.Parameters.AddWithValue("@price", product.Price);
                    command.Parameters.AddWithValue("@quantity", product.Quantity);
                    command.Parameters.AddWithValue("@GST", product.gst);
                    command.Parameters.AddWithValue("@branch", product.Branch);
                    command.Parameters.AddWithValue("@supplier", product.Supplier);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return RedirectToAction("Add", "bil");
            }
            else
            {
                return View();
            }
        }

       
            public ActionResult Invontary(string name, string shopname, string bran)
              
            {
                ViewBag.name = name;
                 ViewBag.shopname = shopname;
            ViewBag.br = bran;

            var branchs = new List<string>();
            var products = new List<Product>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("IF OBJECT_ID('branch', 'U') IS NULL BEGIN " +
                     "CREATE TABLE branch (name VARCHAR(255), shopname VARCHAR(255), branchname VARCHAR(255), location VARCHAR(255))" +
                     "END; " +
                     "SELECT branchname FROM branch where name=@name and shopname=@shopname ;", connection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@shopname", shopname);

                var branchread = command.ExecuteReader();
                while (branchread.Read())
                {
                    branchs.Add(branchread.GetString(0));
                }
                ViewBag.branchs = branchs;
                connection.Close();
                connection.Open();
                if (string.IsNullOrEmpty(bran))
                {

                    command = new SqlCommand("IF OBJECT_ID('Products', 'U') IS NULL BEGIN " +
                           "CREATE TABLE Products (name VARCHAR(255),shopname VARCHAR(255), prodectname VARCHAR(255), description VARCHAR(255), " +
                           "category VARCHAR(255), price FLOAT, quantity INT,gst INT, branch VARCHAR(255), supplier VARCHAR(255)) " +
                           "END; " +
                           "SELECT * FROM Products where name=@name and shopname=@shopname", connection);


                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@shopname", shopname);
                }
                else
                {
                    command = new SqlCommand("IF OBJECT_ID('Products', 'U') IS NULL BEGIN " +
                        "CREATE TABLE Products (name VARCHAR(255),shopname VARCHAR(255), prodectname VARCHAR(255), description VARCHAR(255), " +
                        "category VARCHAR(255), price FLOAT, quantity INT,gst INT, branch VARCHAR(255), supplier VARCHAR(255)) " +
                        "END; " +
                        "SELECT * FROM Products where name=@name and shopname=@shopname and branch = @x", connection);
                    command.Parameters.AddWithValue("@x", bran);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@shopname", shopname);
                   
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product
                        {
                            // Name = reader.GetString(0),
                            // ShopName = reader.GetString(1),
                            ProductName = reader.GetString(2),
                            // Description = reader.GetString(3),
                            Category = reader.GetString(4),
                            Price = (float)reader.GetDouble(5),
                            Quantity = reader.GetInt32(6),
                            gst = reader.GetInt32(7),
                            Branch = reader.GetString(8),
                            Supplier = reader.GetString(9)
                        };

                        products.Add(product);
                        
                    }
                }
                connection.Close();
            }
                
                return View(products);






             
            
            }

        public ActionResult Bill(string name, string shopname,string bra)

        {
            ViewBag.name = name;
            ViewBag.shopname = shopname;

            return View();
        }

        [HttpPost]
        public ActionResult GetProductPrice(string productName)
        {
            
                
           
            return Json("efe");
        }

        [HttpPost]
        public ActionResult Getbranchs(string productName)
        {




            return Json("efe");
        }

        public ActionResult addbranch(string name,string shopname)
        {
            ViewBag.name = name;
            ViewBag.shopname = shopname;
                return View();
            
        }

        public ActionResult Voicebill(string name, string shopname)
        {
            ViewBag.name = name;
            ViewBag.shopname = shopname;


            return View();

        }
        [HttpPost]
        public IActionResult addbranch(branch branch)
        {

            if (ModelState.IsValid)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand("IF OBJECT_ID('branch', 'U') IS NULL BEGIN " +
            "CREATE TABLE branch (name VARCHAR(255), shopname VARCHAR(255), branchname VARCHAR(255), location VARCHAR(255))" +
              "END; " +
                  "INSERT INTO branch(name, shopname, branchname, location) VALUES (@name, @shopname, @branchname, @location)", connection);
                    command.Parameters.AddWithValue("@name", branch.name);
                    command.Parameters.AddWithValue("@shopname", branch.shopname);
                    command.Parameters.AddWithValue("@branchname", branch.branchname);
                    command.Parameters.AddWithValue("@location", branch.location);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    return RedirectToAction("Invontary", new { branch.name, branch.shopname, branch.branchname });

                }
            }
            return Json("efe");
        }

        public JsonResult GetAvailableProducts()
        {
            var availableProducts = new List<string> { "Product 1", "Product 2", "Product 3" };
            return Json(availableProducts, new JsonSerializerSettings());



        }
    }
}






