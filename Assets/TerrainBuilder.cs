using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBuilder : MonoBehaviour
{
	public int boardSize = 10;
	public GameObject terrainOne;
	public GameObject terrainTwo;
	// Start is called before the first frame update
	void Start()
    {
		BlockPlacer(terrainOne, -.5f, 0);
		BlockPlacer(terrainOne, .5f, 1);
		BlockPlacer(terrainTwo, .5f, 0);
		BlockPlacer(terrainTwo, -.5f, 1);
	}

	private void BlockPlacer(GameObject go,float distanceAdjust, float ZdistanceAdjuster)
	{
		for (int j = 0; j < boardSize; j++)
		{
			//Instantiate(go, new Vector3(j + distanceAdjust, -.5f, j * 2f + ZdistanceAdjuster), Quaternion.identity);
			Instantiate(go, new Vector3(j - distanceAdjust, -.5f, j * 2f + ZdistanceAdjuster), Quaternion.identity);

			for (int i = 0; i < boardSize; i++)
			{
				Instantiate(go, new Vector3(i * 2.0F + distanceAdjust, -.5f, j * 2f + ZdistanceAdjuster), Quaternion.identity);
			}
		}
	}

	

	// Update is called once per frame
}
