using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	public void Grow()
	{
        Debug.Log("Clicked");
		transform.localScale *= 1.1f;
	}
}
