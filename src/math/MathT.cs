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
	}
}
