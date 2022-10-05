using UnityEngine;

namespace Com.Surbon.UnityUtils.Mono
{
	/// <summary>
	/// A <see cref="MonoBehaviour"/> with properties added to access some <see cref="Transform"/> properties faster.
	/// </summary>
	public class QuickAccessMonoBehaviour : MonoBehaviour
	{
		/// <summary>
		/// The rotation as euler angles in degrees.
		/// </summary>
		public Vector3 EulerAngles
		{
			get => transform.eulerAngles;
			set => transform.eulerAngles = value;
		}

		/// <summary>
		/// The rotation as euler angles in degrees relative to the parent <see cref="Transform"/>'s rotation.
		/// </summary>
		public Vector3 LocalEulerAngles
		{
			get => transform.localEulerAngles;
			set => transform.localEulerAngles = value;
		}

		/// <summary>
		/// Position of the <see cref="Transform"/> relative to the parent <see cref="Transform"/>.
		/// </summary>
		public Vector3 LocalPosition
		{
			get => transform.localPosition;
			set => transform.localPosition = value;
		}

		/// <summary>
		/// The rotation of the <see cref="Transform"/> relative to the <see cref="Transform"/> rotation of the parent.
		/// </summary>
		public Quaternion LocalRotation
		{
			get => transform.localRotation;
			set => transform.localRotation = value;
		}

		/// <summary>
		/// The scale of the <see cref="Transform"/> relative to the <see cref="GameObject"/>'s parent.
		/// </summary>
		public Vector3 LocalScale
		{
			get => transform.localScale;
			set => transform.localScale = value;
		}

		/// <summary>
		/// The global scale of the object (read only).
		/// </summary>
		public Vector3 LossyScale => transform.lossyScale;

		/// <summary>
		/// The parent of the <see cref="Transform"/>.
		/// </summary>
		public Transform Parent
		{
			get => transform.parent;
			set => transform.parent = value;
		}

		/// <summary>
		/// The world space position of the <see cref="Transform"/>.
		/// </summary>
		public Vector3 Position
		{
			get => transform.position;
			set => transform.position = value;
		}

		/// <summary>
		/// A <see cref="Quaternion"/> that stores the rotation of the <see cref="Transform"/> in world space.
		/// </summary>
		public Quaternion Rotation
		{
			get => transform.rotation;
			set => transform.rotation = value;
		}
	}
}
