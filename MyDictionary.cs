using System;
using System.Collections.Generic;

class MyDictionary<TKey, TValue> {
	(TKey key, TValue value)[] _arr = new (TKey, TValue)[8];

	public int Count {
		get; private set;
	}

	public void Add(TKey key, TValue value) {
		if (Count >= _arr.Length) {
			Array.Resize(ref _arr, _arr.Length << 1);
		}
		_arr[Count++] = (key, value);
	}

	public TValue this[TKey index] {
		get {
			for (int i = 0; i < Count; i++) {
				if (_arr[i].key.Equals(index))
					return _arr[i].value;
			}
			throw new KeyNotFoundException();
		}
	}
}
