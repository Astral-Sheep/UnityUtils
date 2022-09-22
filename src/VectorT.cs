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

		/// <summary>
		/// Returns the cylindric coordinates of the vector from the cartesian coordinates
		/// </summary>
		/// <param name="vector">Cartesian coordinates as (x, y, z)</param>
		/// <returns>Cylindric coordinates as (r, y, phi) with phi in radians</returns>
		public static Vector3 CartesianToCylindric(Vector3 vector)
		{
			return new Vector3(Mathf.Sqrt(vector.x * vector.x + vector.z * vector.z), vector.y, Mathf.Atan2(vector.z, vector.y));
		}

		/// <summary>
		/// Returns the cylindric coordinates of the vector given in cartesian coordinates
		/// </summary>
		/// <returns>Cylindric coordinates as (r, y, phi) with phi in radians</returns>
		public static Vector3 CartesianToCylindric(float x, float y, float z)
		{
			return new Vector3(Mathf.Sqrt(x * x + z * z), y, Mathf.Atan2(z, x));
		}

		/// <summary>
		/// Returns the polar coordinates of the vector given in cartesian coordinates
		/// </summary>
		/// <param name="vector">Cartesian coordinates as (x, y)</param>
		/// <returns>Polar coordinates as (r, th) with th in radians</returns>
		public static Vector2 CartesianToPolar(Vector2 vector)
		{
			return new Vector2(vector.magnitude, Mathf.Atan2(vector.y, vector.x));
		}

		/// <summary>
		/// Returns the polar coordinates of the vector given in cartesian coordinates
		/// </summary>
		/// <returns>Polar coordinates as (r, th) with th in radians</returns>
		public static Vector2 CartesianToPolar(float x, float y)
		{
			return new Vector2(Mathf.Sqrt(x * x + y * y), Mathf.Atan2(y, x));
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector from the cartesian coordinates
		/// </summary>
		/// <param name="vector">Cartesian coordinates as (x, y, z)</param>
		/// <returns>Spheric coordinates as (rho, phi, th) with phi and th in radians</returns>
		public static Vector3 CartesianToSpheric(Vector3 vector)
		{
			return new Vector3(
				vector.magnitude,
				Mathf.Atan2(vector.z, vector.x),
				Mathf.Atan2(vector.y, Mathf.Sqrt(vector.x * vector.x + vector.z * vector.z))
				);
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector from the cartesian coordinates
		/// </summary>
		/// <returns>Spheric coordinates as (rho, phi, th) with phi and th in radians</returns>
		public static Vector3 CartesianToSpheric(float x, float y, float z)
		{
			return new Vector3(
				Mathf.Sqrt(x * x + y * y + z * z),
				Mathf.Atan2(z, x),
				Mathf.Atan2(y, Mathf.Sqrt(x * x + z * z))
				);
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="vector">Cylindric coordinates as (r, y, phi) with phi in radians</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 CylindricToCartesian(Vector3 vector)
		{
			return new Vector3(vector.x * Mathf.Cos(vector.z), vector.y, vector.x * Mathf.Sin(vector.z));
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="r">Polar radius</param>
		/// <param name="y">Cartesian coordinate y</param>
		/// <param name="phi">Azimuth angle in radians</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 CylindricToCartesian(float r, float y, float phi)
		{
			return new Vector3(r * Mathf.Cos(phi), y, r * Mathf.Sin(phi));
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="vector">Cylindric coordinates as (r, y, phi) with phi in radians</param>
		/// <returns>Spheric coordinates as (rho, phi, th) with phi and th in radians</returns>
		public static Vector3 CylindricToSpheric(Vector3 vector)
		{
			return new Vector3(
				Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y),
				vector.z,
				Mathf.Atan2(vector.y, vector.x)
				);
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="r">Polar radius</param>
		/// <param name="y">Cartesian coordinate y</param>
		/// <param name="phi">Azimuth angle in radians</param>
		/// <returns>Spheric coordinates as (rho, phi, th) with phi and th in radians</returns>
		public static Vector3 CylindricToSpheric(float r, float y, float phi)
		{
			return new Vector3(
				Mathf.Sqrt(r * r + y * y),
				phi,
				Mathf.Atan2(y, r)
				);
		}
	}
}