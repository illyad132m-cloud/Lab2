using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_task1
{
	public class PcGame
	{
		private string _title;
		private string _developer;
		private int _realeseDate;
		private string _genre;
		private decimal _price;
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}
		public string Developer
		{
			get { return _developer; }
			set { _developer = value; }
		}
		public string Genre
		{
			get { return _genre; }
			set { _genre = value; }
		}
		public int RealeseDate
		{
			get { return _realeseDate; }
		}
		public decimal Price
		{
			get { return _price; }
			set
			{
				if (value < 0)
				{
					Console.WriteLine($"[Помилка] Ціна не може бути від'ємною ({value}). Встановлено 0.");
					_price = 0;
				}
				else
				{
					_price = value;
				}
			}
		}
		public PcGame()
		{
			_title = "Невідома гра";
			_developer = "Невідомий розробник";
			_realeseDate = 2024;
			_genre = "Не вказано";
			_price = 0m;
		}
		public PcGame(string title, string developer, int realeseDate, string genre, decimal price)
		{
			_title = title;
			_developer = developer;
			_realeseDate = realeseDate;
			_genre = genre;
			Price = price; // Використовуємо властивість для перевірки ціни
		}
		public decimal DiscountedPrice(decimal discountPercentage)
		{
			if (discountPercentage < 0 || discountPercentage > 100)
			{
				return Price;
			}
			else
			{
				decimal discount = Price * (discountPercentage / 100m);
				return Price - discount;
			}
		}
		public void SystemReq(int userRam)
		{
			int requiredRam = 16;
			if (userRam >= requiredRam)
			{
				Console.WriteLine($"Гра '{Title}' запуститься на вашому комп'ютері ");
			}
			else
			{
				Console.WriteLine($"Ваш комп'ютер занадто слабкий щоб запустити '{Title}' ");
			}
		}
		public void DisplayInfo()
		{
			Console.WriteLine($"Назва гри: {Title}");
			Console.WriteLine($"Розробник: {Developer}");
			Console.WriteLine($"Дата релізу: {RealeseDate}");
			Console.WriteLine($"Жанр: {Genre}");
			Console.WriteLine($"Ціна: {Price} грн");
		}
		public void PriceForDLC(decimal perIncrease = 30m)
		{
			decimal icreaseAmount = Price * (perIncrease / 100m);
			Price = Price + icreaseAmount;
			Console.WriteLine($"Вийшло доповнення для '{Title}'! Ціну збільшено на {perIncrease}%.Нова ціна: {Price:F2} ₴");
		}
	}
}
