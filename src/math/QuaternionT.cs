using UnityEngine;

namespace Com.Surbon.UnityUtils.Math
{
	/// <summary>
	/// Provides methods for <see cref="Quaternion"/>.
	/// </summary>
	public static class QuaternionT
	{
		/// <summary>
		/// Returns the given <see cref="Quaternion"/> rotated by the given angle on the given axis.
		/// </summary>
		public static Quaternion Rotate(Quaternion q, float angle, Vector3 axis)
		{
			return q * Quaternion.AngleAxis(angle, axis);
		}

		/// <summary>
		/// Returns the angle of the given <see cref="Quaternion"/>.
		/// </summary>
		/// <returns>The angle in radians.</returns>
		public static float GetAngle(Quaternion q)
		{
			return Mathf.Acos(q.w) * 2f;
		}

		/// <summary>
		/// Returns the axis of the given <see cref="Quaternion"/>
		/// </summary>
		public static Vector3 GetAxis(Quaternion q)
		{
			return new Vector3(q.x, q.y, q.z) / Mathf.Sin(Mathf.Acos(q.w));
		}
	}
}
