using UnityEngine;

namespace Com.Surbon.UnityUtils.src.monobehaviour
{
	public class QuickAccessMonoBehaviour : MonoBehaviour
	{
		public Vector3 Position
		{
			get => transform.position;
			set => transform.position = value;
		}

		public Vector3 LocalPosition
		{
			get => transform.localPosition;
			set => transform.localPosition = value;
		}

		public Quaternion Rotation
		{
			get => transform.rotation;
			set => transform.rotation = value;
		}

		public Quaternion LocalRotation
		{
			get => transform.localRotation;
			set => transform.localRotation = value;
		}

		public Vector3 LocalScale
		{
			get => transform.localScale;
			set => transform.localScale = value;
		}
	}
}
