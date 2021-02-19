using System;

class MyList<T> {
	// Масив для зберігання елементів списку.
	T[] _arr = new T[8];

	// Кількість елементів у списку.
	public int Count {
		get; private set;
	}

	// Додавання елемента до списку.
	public void Add(T item) {
		if (Count >= _arr.Length) {
			// Якщо масив повний, подвоїти його розмір.
			Array.Resize(ref _arr, _arr.Length << 1);
		}
		_arr[Count++] = item;
	}

	// Отримання елемента за індексом.
	public T this[int index] =>
		index < 0 || index >= Count ?
		throw new ArgumentOutOfRangeException(nameof(index)) : _arr[index];
}
