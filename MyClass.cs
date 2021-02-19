class MyClass {
	public static T FactoryMethod<T>() where T : new() => new();
}
