using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit, 100f))
			{
                // Execute something on hit gameobject
                
				GameObject hitGO = hit.transform.gameObject;
                Debug.Log(hitGO);
                TileScript hitTile = hitGO.GetComponent<TileScript>();
				hitTile.Grow();
			}
		}
	}
}
