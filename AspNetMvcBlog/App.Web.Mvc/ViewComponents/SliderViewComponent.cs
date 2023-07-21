using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace App.Web.Mvc.ViewComponents

{

	public class SliderViewComponent : ViewComponent
	{
		public List<SliderModelView> _sliderList = new List<SliderModelView>()
		{
			new SliderModelView
			{
				Name = "Lifestyle",
				Date = "January 2, 2019",
				Image = "../images/slider/slider1.jpg",
				Title = "Tips for Taking a Long-term Trip"
			},
			new SliderModelView
			{
				Name = "Travel",
				Date = "September 15, 2019",
				Image = "..//images/slider/slider2.jpg",
				Title = "Trip to California"
			},
			new SliderModelView
			{
				Name = "Weekends",
				Date = "June 12, 2019",
				Image = "..//images/slider/slider3.jpg",
				Title = "Our Favorite Weekend Getaways"
			}
			,
			new SliderModelView
			{
				Name = "Travel",
				Date = "September 19, 2019",
				Image = "..//images/slider/slider2.jpg",
				Title = "Trip to California"
			},
			new SliderModelView
			{
				Name = "Lifestyle",
				Date = "January 2, 2019",
				Image = "../images/slider/slider1.jpg",
				Title = "Tips for Taking a Long-term Trip"
			},
			new SliderModelView
		{
				Name = "Travel",
				Date = "September 15, 2019",
				Image = "..//images/slider/slider2.jpg",
				Title = "Trip to California"
			},

		};
	
		public IViewComponentResult Invoke()
		{
			return View(_sliderList);
		}
	}
}
