using System;

class MyList<T> {
	T[] _arr = new T[8];

	public int Count {
		get; private set;
	}

	public void Add(T item) {
		if (Count >= _arr.Length) {
			Array.Resize(ref _arr, _arr.Length << 1);
		}
		_arr[Count++] = item;
	}

	public T this[int index] =>
		index < 0 || index >= Count ?
		throw new ArgumentOutOfRangeException(nameof(index)) : _arr[index];
}
