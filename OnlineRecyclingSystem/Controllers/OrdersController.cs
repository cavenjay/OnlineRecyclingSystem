using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineRecyclingSystem.Areas.Identity.Data;
using OnlineRecyclingSystem.Data;
using OnlineRecyclingSystem.Models;

namespace OnlineRecyclingSystem.Views
{
    public class OrdersController : Controller
    {
        private readonly OnlineRecyclingSystemOrder _context;
        private readonly UserManager<OnlineRecyclingSystemUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public OrdersController(OnlineRecyclingSystemOrder context, UserManager<OnlineRecyclingSystemUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;

        }
        public SelectList RoleSelectList = new SelectList(

            new List<SelectListItem>
            {
                new SelectListItem { Selected = true, Text = "Select Time", Value = ""},
                new SelectListItem { Selected = true, Text = "8am-11am", Value = "8am-11am"},
                new SelectListItem { Selected = true, Text = "11am-2pm", Value = "11am-2pm"},
                new SelectListItem { Selected = true, Text = "2pm-5pm", Value = "2pm-5pm"},
                new SelectListItem { Selected = true, Text = "5pm-8pm", Value = "5pm-8pm"},
            }, "Value", "Text", 1);


        public async Task<IActionResult> DriverIndex(string DriverName)
        {
            var order = from m in _context.Order
                        select m;
            

            if (!String.IsNullOrEmpty(DriverName))
            {
                order = order.Where(s => s.DriverName.Contains(DriverName));
            }


            return View(await order.ToListAsync());
        }
        public async Task<IActionResult> DriverView(string OrderStatus)
        {
            var order = from m in _context.Order
                        select m;


            IQueryable<string> TypeQuery = from m in _context.Order
                                           orderby m.OrderStatus
                                           select m.OrderStatus;
            IEnumerable<SelectListItem> items =
                new SelectList(await TypeQuery.Distinct().ToListAsync());
            ViewBag.OrderStatus = items;

            if (!String.IsNullOrEmpty(OrderStatus))
            {
                order = order.Where(s => s.OrderStatus == OrderStatus);
            }


            return View(await order.ToListAsync());

        
    }
        public async Task<IActionResult> AcceptOrder(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AcceptOrder(int id, [Bind("ID,OrderDate,CusName,CusContact,CusAddress,BigBottle,SmallBottle,Can,DriverName,DriverContact,OrderStatus,OrderTime")] Order order)
        {
            if (id != order.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(DriverView));
            }
            return View(order);
        }
        public async Task<IActionResult> CompleteOrder(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompleteOrder(int id, [Bind("ID,OrderDate,CusName,CusContact,CusAddress,BigBottle,SmallBottle,Can,DriverName,DriverContact,OrderStatus,OrderTime")] Order order)
        {
            if (id != order.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(DriverView));
            }
            return View(order);
        }


        public string ReturnUrl { get; set; }
        public async Task<IActionResult> CusIndex(string OrderStatus)
        {

            var order = from m in _context.Order
                         select m;
            

            IQueryable<string> TypeQuery = from m in _context.Order
                                           orderby m.OrderStatus
                                           select m.OrderStatus;
            IEnumerable<SelectListItem> items =
                new SelectList(await TypeQuery.Distinct().ToListAsync());
            ViewBag.OrderStatus = items;

            if (!String.IsNullOrEmpty(OrderStatus))
            {
                order = order.Where(s => s.OrderStatus == OrderStatus);
            }


            return View(await order.ToListAsync());

        }

        // GET: Orders
        public async Task<IActionResult> Index(string CusName,string DriverName, string OrderStatus)
        {
            var order = from m in _context.Order
                         select m;
            if (!String.IsNullOrEmpty(CusName))
            {
                order = order.Where(s => s.CusName.Contains(CusName));
            }

            if (!String.IsNullOrEmpty(DriverName))
            {
                order = order.Where(s => s.DriverName.Contains(DriverName));
            }
            
            IQueryable<string> TypeQuery = from m in _context.Order
                                           orderby m.OrderStatus
                                           select m.OrderStatus;
            IEnumerable<SelectListItem> items =
                new SelectList(await TypeQuery.Distinct().ToListAsync());
            ViewBag.OrderStatus = items;

            if (!String.IsNullOrEmpty(OrderStatus))
            {
                order = order.Where(s => s.OrderStatus == OrderStatus);
            }


            return View(await order.ToListAsync());
        }
        
        
        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        public IActionResult CusCreate()
        {


            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CusCreate([Bind("ID,OrderDate,CusName,CusContact,CusAddress,BigBottle,SmallBottle,Can,DriverName,DriverContact,OrderStatus,OrderTime")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CusIndex));
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> CusEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CusEdit(int id, [Bind("ID,OrderDate,CusName,CusContact,CusAddress,BigBottle,SmallBottle,Can,DriverName,DriverContact,OrderStatus,OrderTime")] Order order)
        {
            if (id != order.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(CusIndex));
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> CusDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("CusDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CusDeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(CusIndex));
        }




        // GET: Orders/Create
        public IActionResult Create()
        {

            
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,OrderDate,CusName,CusContact,CusAddress,BigBottle,SmallBottle,Can,DriverName,DriverContact,OrderStatus,OrderTime")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,OrderDate,CusName,CusContact,CusAddress,BigBottle,SmallBottle,Can,DriverName,DriverContact,OrderStatus,OrderTime")] Order order)
        {
            if (id != order.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.ID == id);
        }
    }
}
