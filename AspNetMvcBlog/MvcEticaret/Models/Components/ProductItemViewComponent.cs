﻿using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.Models.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int starCount, double oldPrice, double price, string imageUrl, bool isSale)
        {
            var product = new Product()
            {
                Title = title,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale,
                OldPrice = oldPrice,
                StarCount = starCount
            };

            return View(product);
        }
    }
}
