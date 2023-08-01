using System;

static class Program {
	static T[] GetArray<T>(this MyList<T> list) {
		T[] result = new T[list.Count];
		for (int i = 0; i < list.Count; i++)
			result[i] = list[i];
		return result;
	}

	static readonly Random rng = MyClass.FactoryMethod<Random>();
	static int GetRandomInt() => (rng.Next() << 1) ^ rng.Next();

	static void Main(string[] args) {
		Console.Title = "Лабораторна 2";
		Console.OutputEncoding = System.Text.Encoding.UTF8;

		MyList<int> list = new();
		for (int i = rng.Next(22); i != 0; i--)
			list.Add(GetRandomInt());

		MyDictionary<char, string> dictionary = new();
		char c = 'A';
		foreach (string s in args)
			dictionary.Add(c++, s);

		Console.WriteLine($"Розмір словника: {dictionary.Count}");
		c = 'A';
		for (int i = 0; i < dictionary.Count; i++) {
			Console.WriteLine($"{c} {dictionary[c]}");
			c++;
		}

		Console.WriteLine($"Розмір списка: {list.Count}");
		foreach (int i in list.GetArray())
			Console.WriteLine(i);

		while (Console.KeyAvailable)
			Console.ReadKey(true);
		Console.WriteLine("А на цьому все! Натисніть Enter, щоб продовжити...");
		while (Console.ReadKey(true).Key != ConsoleKey.Enter) {
		}
	}
}
