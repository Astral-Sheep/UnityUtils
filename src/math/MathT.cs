using System;
using System.Collections.Generic;
using UnityEngine;

namespace Com.Surbon.UnityUtils.Math
{
	/// <summary>
	/// Provides mathematicals method for Unity
	/// </summary>
	public static class MathT
	{
		/// <summary>
		/// Returns the euclidian quotient of a / b
		/// </summary>
		public static float EuclidianQuotient(float a, float b)
		{
			return Mathf.Floor(a / b);
		}

		/// <summary>
		/// Returns the euclidian remainder of a / b
		/// </summary>
		public static float EuclidianRemainder(float a, float b)
		{
			return a - Mathf.Floor(a / b) * b;
		}

		/// <summary>
		/// Returns the euclidian remainder of a / b
		/// </summary>
		public static int EuclidianRemainder(int a, int b)
		{
			return a - (a / b) * b;
		}

		/// <summary>
		/// Returns the product of all natural numbers lesser than or equal to value
		/// </summary>
		public static uint Factorial(uint value)
		{
			uint f = 1;

			for (uint i = 1; i <= value; i++)
			{
				f *= i;
			}

			return f;
		}

		/// <summary>
		/// Returns the product of all natural numbers lesser than or equal to value
		/// </summary>
		public static int Factorial(int value)
		{
			if (value < 0)
				throw new ArgumentOutOfRangeException("The value must be greater than 0.");

			int f = 1;

			for (int i = 1; i <= value; i++)
			{
				f *= i;
			}

			return f;
		}

		/// <summary>
		/// Returns a modulo b
		/// </summary>
		/// <param name="isPos">If false, it is the negative modulo (if you're sure it will be true, use <see cref="EuclidianRemainder(float, float)"/> instead)</param>
		public static float Mod(float a, float b, bool isPos = true)
		{
			return a - Mathf.Floor(a / b) * b - (isPos ? 0 : b);
		}

		/// <summary>
		/// Returns a modulo b
		/// </summary>
		/// <param name="isPos">If false, it is the negative modulo (if you're sure it will be true, use <see cref="EuclidianRemainder(int, int)"/> instead)</param>
		public static int Mod(int a, int b, bool isPos = true)
		{
			return a - (int)Mathf.Floor(a / b) * b - (isPos ? 0 : b);
		}

		/// <summary>
		/// Returns value to the power of -pow
		/// </summary>
		/// <param name="pow">Must be greater than 0 or it will return 1</param>
		public static float NegPow(float value, int pow)
		{
			float p = 1;

			for (int i = 0; i < pow; i++)
			{
				p /= value;
			}

			return p;
		}

		/// <summary>
		/// Returns the nth root of the given number
		/// </summary>
		public static float NRoot(float value, float n)
		{
			return Mathf.Exp(Mathf.Log(value) / n);

		}

		/// <summary>
		/// Returns value to the power of pow
		/// </summary>
		/// <param name="pow">Must be greater than 0 or it will return 1</param>
		public static float PosPow(float value, int pow)
		{
			float p = 1;

			for (int i = 0; i < pow; i++)
			{
				p *= value;
			}

			return p;
		}

		/// <summary>
		/// Returns value to the power of pow
		/// </summary>
		public static float Pow(float value, int pow)
		{
			return pow < 0 ? NegPow(value, pow * -1) : PosPow(value, pow);
		}

		/// <summary>
		/// Returns the sum of all natural numbers lesser than or equal to value
		/// </summary>
		public static uint Sum(uint value)
		{
			uint s = 0;

			for (uint i = 1; i <= value; i++)
			{
				s += i;
			}

			return s;
		}

		/// <summary>
		/// Returns the sum of all natural numbers lesser than or equal to value
		/// </summary>
		public static int Sum(int value)
		{
			if (value < 0)
				throw new ArgumentOutOfRangeException("The value must be greater than 0.");

			int s = 0;

			for (int i = 1; i <= value; i++)
			{
				s += i;
			}

			return s;
		}

		/// <summary>
		/// Returns the sum of all whole numbers between start and end (if start is greater than end it returns 0)
		/// </summary>
		public static uint Sum(uint start, uint end)
		{
			uint s = 0;

			for (uint i = start; i <= end; i++)
			{
				s += i;
			}

			return s;
		}

		/// <summary>
		/// Returns the sum of all integers between start and end (if start is greater than end it returns 0)
		/// </summary>
		public static int Sum(int start, int end)
		{
			int s = 0;

			for (int i = start; i <= end; i++)
			{
				s += i;
			}

			return s;
		}
	}
}
