using System.Collections.Generic;
using UnityEngine;

namespace Com.Surbon.UnityUtils.Math
{
	/// <summary>
	/// Provides methods for Unity vectors
	/// </summary>
	public static class VectorT
	{
		/// <summary>
		/// Enum for 3D axis
		/// </summary>
		public enum Axis
		{
			X = 0,
			Y = 1,
			Z = 2
		}

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
		
		/// <summary>
		/// Sets the length of the vector to the given length (1 by default)
		/// </summary>
		public static Vector2 Normalize(Vector2 vector, float length = 1)
		{
			float l = vector.sqrMagnitude;

			if (l == 0 || l == length * length)
				return vector;

			l = Mathf.Sqrt(l) / length;
			return new Vector2(vector.x / l, vector.y / l);
		}

		/// <summary>
		/// Sets the length of the vector to the given length (1 by default)
		/// </summary>
		public static Vector3 Normalize(Vector3 vector, float length = 1)
		{
			float l = vector.sqrMagnitude;

			if (l == 0 || l == length * length)
				return vector;

			l = Mathf.Sqrt(l) / length;
			return new Vector3(vector.x / l, vector.y / l, vector.z / l);
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in polar coordinates
		/// </summary>
		/// <param name="vector">Polar coordinates as (r, th) with th in radians</param>
		/// <returns>Cartesian coordinates as (x, y)</returns>
		public static Vector2 PolarToCartesian(Vector2 vector)
		{
			return new Vector2(vector.x * Mathf.Cos(vector.y), vector.y * Mathf.Sin(vector.y));
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in polar coordinates
		/// </summary>
		/// <param name="r">Radius</param>
		/// <param name="th">Angle in radians</param>
		/// <returns>Cartesian coordinates as (x, y)</returns>
		public static Vector2 PolarToCartesian(float r, float th)
		{
			return new Vector2(r * Mathf.Cos(th), r * Mathf.Sin(th));
		}

		/// <summary>
		/// Rotates the given vector by the given angle
		/// </summary>
		/// <param name="phi">Angle in radians</param>
		/// <returns>The rotated vector</returns>
		public static Vector2 Rotate(Vector2 vector, float phi)
		{
			float angle = Mathf.Atan2(vector.y, vector.x) - phi;
			float length = vector.magnitude;
			return new Vector2(Mathf.Cos(angle) * length, Mathf.Sin(angle) * length);
		}

		/// <summary>
		/// Rotates the given vector by the given angle on the given axis
		/// </summary>
		/// <param name="phi">Angle in radians</param>
		/// <param name="axis">Axis on which it turns around</param>
		/// <returns>The rotated vector</returns>
		public static Vector3 Rotate(Vector3 vector, float phi, Axis axis)
		{
			float angle;
			float length;

			switch (axis)
			{
				case Axis.X:
					angle = Mathf.Atan2(vector.y, vector.z) + phi;
					length = Mathf.Sqrt(vector.y * vector.y + vector.z * vector.z);
					return new Vector3(vector.x, Mathf.Sin(angle) * length, Mathf.Cos(angle) * length);
				case Axis.Y:
					angle = Mathf.Atan2(vector.x, vector.z) + phi;
					length = Mathf.Sqrt(vector.x * vector.x + vector.z * vector.z);
					return new Vector3(Mathf.Sin(angle) * length, vector.y, Mathf.Cos(angle) * length);
				case Axis.Z:
					angle = Mathf.Atan2(vector.x, vector.y) + phi;
					length = Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y);
					return new Vector3(Mathf.Sin(angle) * length, Mathf.Cos(angle) * length, vector.z);
				default:
					Debug.LogError("How tf did you get here? Returning infinity vector.");
					return Vector3.positiveInfinity;
			}
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="vector">Spheric coordinates as (rho, phi, th) with phi and th in radians</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 SphericToCartesian(Vector3 vector)
		{
			return new Vector3(
				vector.x * Mathf.Cos(vector.y) * Mathf.Sin(vector.z),
				vector.x * Mathf.Cos(vector.z),
				vector.x * Mathf.Sin(vector.y) * Mathf.Sin(vector.z)
				);
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="rho">Spheric radius</param>
		/// <param name="phi">Azimuth angle in radians</param>
		/// <param name="th">Polar angle in radians</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 SphericToCartesian(float rho, float phi, float th)
		{
			return new Vector3(
				rho * Mathf.Cos(phi) * Mathf.Sin(th),
				rho * Mathf.Cos(th),
				rho * Mathf.Sin(phi) * Mathf.Sin(th)
				);
		}

		/// <summary>
		/// Returns the cylindric coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="vector">Spheric coordinates as (rho, phi, th) with phi and th in radians</param>
		/// <returns>Cylindric coordinates as (r, phi, z) with phi in radians</returns>
		public static Vector3 SphericToCylindric(Vector3 vector)
		{
			return new Vector3(
				vector.x * Mathf.Sin(vector.z),
				vector.x * Mathf.Cos(vector.z),
				vector.y
				);
		}

		/// <summary>
		/// Returns the cylindric coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="rho">Spheric radius</param>
		/// <param name="phi">Azimuth angle in radians</param>
		/// <param name="th">Polar angle in radians</param>
		/// <returns>Cylindric coordinates as (r, phi, z) with phi in radians</returns>
		public static Vector3 SphericToCylindric(float rho, float phi, float th)
		{
			return new Vector3(
				rho * Mathf.Sin(th),
				rho * Mathf.Cos(th),
				phi
				);
		}
	}
}