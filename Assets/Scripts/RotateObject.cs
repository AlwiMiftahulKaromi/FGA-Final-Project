using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private InputAction pressed, axis;
	[SerializeField] private float speed = 0.2f;

	private Transform cam;
	private Vector2 rotation;
	private bool rotateAllowed;

	private void Awake()
	{
		cam = Camera.main.transform;
		pressed.Enable();
		axis.Enable();
		pressed.performed += _ => { StartCoroutine(Rotate()); };
		pressed.canceled += _ => { rotateAllowed = false; };
		axis.performed += context => { rotation = context.ReadValue<Vector2>(); };
	}

	private IEnumerator Rotate()
	{
		rotateAllowed = true;
		while(rotateAllowed)
		{
			rotation *= speed;
			//transform.Rotate(Vector3.up, rotation.x, Space.World);
			//transform.Rotate(Vector3.right, rotation.y, Space.World);
			transform.Rotate(-Vector3.up, rotation.x, Space.World);
			//transform.Rotate(-cam.right, rotation.y, Space.World);
			yield return null;
		}
	}

}
