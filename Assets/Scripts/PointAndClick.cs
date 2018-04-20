using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {

	void Update()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		// Check hovered tile
		if (Physics.Raycast(ray, out hit, 100f))
		{
			GameObject hitGO = hit.transform.gameObject;
			TileScript hitTile = hitGO.GetComponent<TileScript>();
			hitTile.TileIsHovered();

			// Grow the tile on click
			if (Input.GetMouseButtonDown(0))
			{
				hitTile.Grow();
			}
		}
		
		
	}
}