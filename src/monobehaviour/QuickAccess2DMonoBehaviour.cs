using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Com.Surbon.UnityUtils.Mono
{
	public class QuickAccess2DMonoBehaviour : MonoBehaviour
	{
		public Vector2 LocalPosition2D
		{
			get => new Vector2(transform.localPosition.x, transform.localPosition.y);
			set => transform.localPosition = new Vector3(value.x, value.y, transform.localPosition.z);
		}

		public float LocalRotation2D
		{
			get => transform.localEulerAngles.z;
			set => transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, value);
		}

		public Vector2 LocalScale2D
		{
			get => new Vector2(transform.localScale.x, transform.localScale.y);
			set => transform.localScale = new Vector3(value.x, value.y, transform.localScale.z);
		}

		public Vector2 Position2D
		{
			get => new Vector2(transform.position.x, transform.position.y);
			set => transform.position = new Vector3(value.x, value.y, transform.position.z);
		}

		public float Rotation2D
		{
			get => transform.eulerAngles.z;
			set => transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, value);
		}
	}
}
