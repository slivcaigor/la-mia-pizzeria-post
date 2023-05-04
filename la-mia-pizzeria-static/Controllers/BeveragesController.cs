using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class BeveragesController : Controller
    {
        private readonly List<Listing> listings = new List<Listing> {
            new Listing {
                Id = 1,
                Name = "Coca-Cola",
                Image = "/img/coca-cola.png",
                Description = "Classic cola made with natural flavors and no added preservatives.",
                Price = 2.59,
                IsNew = false
            },
            new Listing {
                Id = 2,
                Name = "Sprite",
                Image = "/img/sprite.png",
                Description = "Lemon-lime soda with a crisp, clean taste.",
                Price = 1.79,
                IsNew = false
            },
            new Listing {
                Id = 3,
                Name = "Fanta",
                Image = "/img/fanta.png",
                Description = "Orange-flavored soda that's fun, fruity, and full of flavor.",
                Price = 1.28,
                IsNew = false
            },
            new Listing {
                Id = 5,
                Name = "Dr Pepper",
                Image = "/img/dr-pepper.png",
                Description = "Unique blend of 23 flavors that's been satisfying taste buds since 1885.",
                Price = 1.49,
                IsNew = false
            },
            new Listing {
                Id = 6,
                Name = "Mountain Dew",
                Image = "/img/mountain-dew.png",
                Description = "Citrus-flavored soda that's bold, refreshing, and energizing.",
                Price = 2.29,
                IsNew = false
            },
            new Listing {
                Id = 7,
                Name = "Pepsi",
                Image = "/img/pepsi.png",
                Description = "Refreshing cola made with natural flavors and no artificial preservatives.",
                Price = 2.19,
                IsNew = false
            },
        };

        public IActionResult Details(int id)
        {
            var listing = listings.FirstOrDefault(l => l.Id == id);

            if (id < 1 || id > listings.Count)
            {
                return View("Error404");
            }

            return View(listing);
        }

        public IActionResult Index()
        {
            return View(listings);
        }
    }
}
