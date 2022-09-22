using UnityEngine;

namespace Com.Surbon.UnityUtils.Math
{
	public static class VectorT
	{
		/// <summary>
		/// Returns the given vector with absolute values
		/// </summary>
		public static Vector2 Abs(Vector2 vector)
		{
			return new Vector2(
				Mathf.Abs(vector.x),
				Mathf.Abs(vector.y)
				);
		}

		/// <summary>
		/// Returns the given vector with absolute values
		/// </summary>
		public static Vector3 Abs(Vector3 vector)
		{
			return new Vector3(
				Mathf.Abs(vector.x),
				Mathf.Abs(vector.y),
				Mathf.Abs(vector.z)
				);
		}
	}
}