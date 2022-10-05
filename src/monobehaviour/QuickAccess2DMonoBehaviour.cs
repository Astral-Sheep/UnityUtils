using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Com.Surbon.UnityUtils.Mono
{
	/// <summary>
	/// A <see cref="MonoBehaviour"/> with properties added to access some <see cref="Transform"/>'s properties faster and made for 2D behaviours.
	/// </summary>
	public class QuickAccess2DMonoBehaviour : MonoBehaviour
	{
		/// <summary>
		/// Position of the <see cref="Transform"/> on the x and y axis relative to the parent <see cref="Transform"/>.
		/// </summary>
		public Vector2 LocalPosition2D
		{
			get => new Vector2(transform.localPosition.x, transform.localPosition.y);
			set => transform.localPosition = new Vector3(value.x, value.y, transform.localPosition.z);
		}

		/// <summary>
		/// The rotation on the z axis in degrees relative to the parent <see cref="Transform"/>.
		/// </summary>
		public float LocalRotation2D
		{
			get => transform.localEulerAngles.z;
			set => transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, value);
		}

		/// <summary>
		/// The scale of the <see cref="Transform"/> on the x and y axis relative to the parent <see cref="Transform"/>.
		/// </summary>
		public Vector2 LocalScale2D
		{
			get => new Vector2(transform.localScale.x, transform.localScale.y);
			set => transform.localScale = new Vector3(value.x, value.y, transform.localScale.z);
		}

		/// <summary>
		/// The global scale on the x and y axis of the object (Read Only).
		/// </summary>
		public Vector2 LossyScale2D => new Vector2(transform.lossyScale.x, transform.lossyScale.y);

		/// <summary>
		/// The parent of the <see cref="Transform"/>.
		/// </summary>
		public Transform Parent
		{
			get => transform.parent;
			set => transform.parent = value;
		}

		/// <summary>
		/// The world space position of the <see cref="Transform"/> on the x and y axis.
		/// </summary>
		public Vector2 Position2D
		{
			get => new Vector2(transform.position.x, transform.position.y);
			set => transform.position = new Vector3(value.x, value.y, transform.position.z);
		}

		/// <summary>
		/// The rotation on the z axis in degrees.
		/// </summary>
		public float Rotation2D
		{
			get => transform.eulerAngles.z;
			set => transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, value);
		}
	}
}
