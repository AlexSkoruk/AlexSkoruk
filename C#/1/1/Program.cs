using System;

namespace _1
{
	internal class Program
	{
		private static void Main()
        {
			//Method1();

			Point p1 = new(1, 1);
			(var x, var y) = p1;
			x = 2;
			p1 = new(x, y);
        }

		private static void Method1(object obj = null)
        {
            ClassExample refVariable = new();
			StructExample structVariable = new();

            var refVariable_2 = refVariable;
            var structVariable_2 = structVariable;

            refVariable_2.n = 1;
            structVariable_2.n = 1;

            Console.WriteLine($"class {refVariable.n} -> {refVariable_2.n} | struct {structVariable.n} -> {refVariable_2.n}");
        }
    }

	struct StructExample : IFoo
	{
		public int n = 0;

        public StructExample()
        {
        }

		public int N
		{
			get => 25;
			set => n = value;
		}

		public void Foo()
		{
			throw new NotImplementedException();
		}

		public void Deconstruct(out int n)
		{
			n = this.n;
		}
	}

	class ClassExample : IFoo
	{
		public int n = 0;

		public ClassExample() { }

		public int N 
		{
			get => n; 
			set => n = value; 
		}

        public void Foo()
        {
            throw new NotImplementedException();
        }

		public void Deconstruct(out int n)
		{
			n = this.n;
		}
    }

	enum EnumExample : long
	{
		Spring = 0b_0001,
		Summer = 0b_0010,
		Autumn = 0b_0100,
		Winter = 0b_1000
	}

	interface IFoo 
	{
		int N { get; set; }
		void Foo();
	}

	delegate void Foo();

	public record Point( int X, int Y);


	namespace _2
	{

		struct structExample
		{

		}

		class classExample
		{

		}
		enum enumExample
		{

		}

		interface IFoo { }

		delegate void Foo();
	}
}

