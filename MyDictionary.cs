using System;
using System.Collections.Generic;

class MyDictionary<TKey, TValue> {
	// Масив для зберігання елементів словника.
	(TKey key, TValue value)[] _arr = new (TKey, TValue)[8];

	// Кількість елементів у словнику.
	public int Count {
		get; private set;
	}

	// Додавання елемента до словника.
	public void Add(TKey key, TValue value) {
		if (Count >= _arr.Length) {
			// Якщо масив повний, подвоїти його розмір.
			Array.Resize(ref _arr, _arr.Length << 1);
		}
		_arr[Count++] = (key, value);
	}

	// Отримання елемента за індексом.
	public TValue this[TKey index] {
		get {
			for (int i = 0; i < Count; i++) {
				if (_arr[i].key.Equals(index))
					return _arr[i].value;
			}
			// Елемент не знайдено — виняток.
			throw new KeyNotFoundException();
		}
	}
}
