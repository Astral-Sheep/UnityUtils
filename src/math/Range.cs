using System;
using UnityEngine;

namespace Com.Surbon.UnityUtils.Math
{
	/// <summary>
	/// Representation of a range of numbers.
	/// </summary>
	[Serializable]
	public struct Range
	{
		/// <summary>
		/// The minimum value of the range.
		/// </summary>
		public float Min
		{
			get => _min;
			set
			{
				if (value > _max)
					value = _max;

				_min = value;
			}
		}

		/// <summary>
		/// The maximum value of the range.
		/// </summary>
		public float Max
		{
			get => _max;
			set
			{
				if (value < _min)
					value = _min;

				_max = value;
			}
		}

		/// <summary>
		/// The internal minimum value of the range.
		/// </summary>
		[SerializeField] private float _min;
		/// <summary>
		/// The internal maximum value of the range.
		/// </summary>
		[SerializeField] private float _max;

		/// <summary>
		/// Says if the given number belongs to the range.
		/// </summary>
		public bool BelongsTo(float n)
		{
			return n >= _min && n <= _max;
		}

		/// <summary>
		/// Returns a random number between the minimum and the maximum.
		/// </summary>
		public float GetRandom()
		{
			return UnityEngine.Random.Range(_min, _max);
		}

		/// <summary>
		/// Says if the given number belongs to the given range.
		/// </summary>
		public static bool BelongsTo(float n, float min, float max)
		{
			return n >= min && n <= max;
		}
	}
}
