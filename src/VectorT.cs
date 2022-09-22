using System.Collections.Generic;
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

		/// <summary>
		/// Returns the barycenter of the given list of points
		/// </summary>
		/// <param name="vectors">The list of points with all weights set to 1</param>
		/// <returns>The barycenter of the points</returns>
		public static Vector2 Barycenter(List<Vector2> vectors)
		{
			float x = 0, y = 0;

			for (int i = vectors.Count - 1; i >= 0; i--)
			{
				x += vectors[i].x;
				y += vectors[i].y;
			}

			return new Vector2(x / vectors.Count, y / vectors.Count);
		}

		/// <summary>
		/// Returns the barycenter of the given list of points
		/// </summary>
		/// <param name="vectors">The list of points and weights</param>
		/// <returns>The barycenter of the points</returns>
		public static Vector2 Barycenter(List<(Vector2 vector, float weight)> vectors)
		{
			float x = 0, y = 0, weight = 0;

			for (int i = vectors.Count - 1; i >= 0; i--)
			{
				x += vectors[i].vector.x * vectors[i].weight;
				y += vectors[i].vector.y * vectors[i].weight;
				weight += vectors[i].weight;
			}

			return new Vector2(x / weight, y / weight);
		}

		/// <summary>
		/// Returns the barycenter of the given list of points
		/// </summary>
		/// <param name="vectors">The list of points with all weights set to 1</param>
		/// <returns>The barycenter of the points</returns>
		public static Vector3 Barycenter(List<Vector3> vectors)
		{
			float x = 0, y = 0, z = 0;

			for (int i = vectors.Count - 1; i >= 0; i--)
			{
				x += vectors[i].x;
				y += vectors[i].y;
				z += vectors[i].z;
			}

			return new Vector3(x / vectors.Count, y / vectors.Count, z / vectors.Count);
		}

		/// <summary>
		/// Returns the barycenter of the given list of points
		/// </summary>
		/// <param name="vectors">The list of points and weights</param>
		/// <returns>The barycenter of the points</returns>
		public static Vector3 Barycenter(List<(Vector3 vector, float weight)> vectors)
		{
			float x = 0, y = 0, z = 0, weight = 0;

			for (int i = vectors.Count - 1; i >= 0; i--)
			{
				x += vectors[i].vector.x * vectors[i].weight;
				y += vectors[i].vector.y * vectors[i].weight;
				z += vectors[i].vector.z * vectors[i].weight;
				weight += vectors[i].weight;
			}

			return new Vector3(x / weight, y / weight, z / weight);
		}
	}
}