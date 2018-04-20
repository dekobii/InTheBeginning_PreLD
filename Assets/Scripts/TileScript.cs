using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	public void Grow()
	{
		transform.localScale *= 1.1f;
	}
}
