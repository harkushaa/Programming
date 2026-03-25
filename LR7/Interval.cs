namespace LR7
{
	class Interval(double _left, double _right) : IComparable<Interval>
	{
		public double Left { get => _left; }
		public double Right { get => _right; set => _right = value; }

		public double GetLength() =>
			_right - _left - 1;

		public static Interval operator +(Interval firstInterval, Interval secondInterval) =>
			new Interval(firstInterval.Left + secondInterval.Left, firstInterval.Right + secondInterval.Right);

		public static Interval operator -(Interval firstInterval, Interval secondInterval) =>
			new Interval(firstInterval.Left - secondInterval.Left, firstInterval.Right - secondInterval.Right);

		public static Interval operator *(Interval firstInterval, Interval secondInterval)
		{
			if (firstInterval.Right >= secondInterval.Left)
				return new Interval(Math.Min(firstInterval.Right, secondInterval.Left), Math.Max(firstInterval.Right, secondInterval.Left));
			if (secondInterval.Right >= firstInterval.Left)
				return new Interval(Math.Min(secondInterval.Right, firstInterval.Left), Math.Max(secondInterval.Right, firstInterval.Left));
			return new Interval(0, 0);
		}

		public static Interval operator ++(Interval interval)
		{
			interval.Right++;
			return interval;
		}

		public static Interval operator --(Interval interval)
		{
			interval.Right--;
			return interval;
		}

		public int CompareTo(Interval? interval) =>
			this.GetLength().CompareTo(interval!.GetLength());

		public static bool operator >(Interval firstInterval, Interval secondInterval) =>
			firstInterval.CompareTo(secondInterval) > 0;

		public static bool operator >=(Interval firstInterval, Interval secondInterval) =>
			firstInterval.CompareTo(secondInterval) >= 0;

		public static bool operator ==(Interval firstInterval, Interval secondInterval) =>
			firstInterval.Equals(secondInterval);

		public static bool operator !=(Interval firstInterval, Interval secondInterval) =>
			!firstInterval.Equals(secondInterval);

		public static bool operator <=(Interval firstInterval, Interval secondInterval) =>
			firstInterval.CompareTo(secondInterval) <= 0;

		public static bool operator <(Interval firstInterval, Interval secondInterval) =>
			firstInterval.CompareTo(secondInterval) < 0;

		public static bool operator true(Interval interval) =>
			interval.GetLength() != 0;

		public static bool operator false(Interval interval) =>
			interval.GetLength() == 0;

		public static explicit operator double(Interval interval) =>
			interval.GetLength();

		public static explicit operator Interval(double value) =>
			new Interval(0, value - 1);

		public double this[int index] { get => (index == 0) ? _left : (index == 1) ? _right : throw new Exception("Index out of range!"); }


		public override bool Equals(object? obj) =>
			this.GetHashCode() == obj!.GetHashCode();

		public override int GetHashCode()
		{
			return (int)(this.Left * 64 + this.Right * 1000);
		}

		public override string? ToString() =>
			$"({_left}, {_right})";
	}
}
