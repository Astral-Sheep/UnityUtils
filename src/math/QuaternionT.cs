using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Com.Surbon.UnityUtils.Math
{
	/// <summary>
	/// Provides methods for <see cref="Quaternion"/>.
	/// </summary>
	public static class QuaternionT
	{
		/// <summary>
		/// Returns the given quaternion rotated by the given angle on the given axis.
		/// </summary>
		public static Quaternion Rotate(Quaternion q, float angle, Vector3 axis)
		{
			return q * Quaternion.AngleAxis(angle, axis);
		}
	}
}
