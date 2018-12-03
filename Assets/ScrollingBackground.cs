using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	public float scrollSpeed;
	public float tileSizeZ;

	private Vector3 startPosition;

	void Start ()
	{
		scrollSpeed = 1.0f;
		tileSizeZ = 100.0f;
		startPosition = transform.position; // position of the transform in space
	}

	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ); // repeatedly scrolles you through the same loop in space
		transform.position = startPosition - Vector3.forward * newPosition; //
	}
}
