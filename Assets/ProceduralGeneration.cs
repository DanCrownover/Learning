using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    [SerializeField] int width, height;
    [SerializeField] int minStoneheight, maxStoneheight;
    [SerializeField] GameObject dirt, grass, stone;
    // Start is called before the first frame update
    void Start()
    {
        Generation();
    }

    void Generation()
    {
        // spawns tile on the x axis
        for (int x = 0; x < width; x++)
        {
            // for procedural generation, height and width needs to gradually increase & decrease
            int minHeight = height - 1;
            int maxHeight = height + 2;
            height = Random.Range(minHeight, maxHeight);
            int minStoneSpawnDistance = height - minStoneheight;
            int maxStoneSpawnDistance = height - maxStoneheight;
            int totalStoneSpawnDistance = Random.Range (minStoneSpawnDistance, maxStoneSpawnDistance);
            // spawns tile on the y axis
            for (int y = 0; y < height; y++)
            {
                //Instantiate(dirt, new Vector2(x, y), Quaternion.identity);
                if (y < totalStoneSpawnDistance)
                { spawnObj(stone, x, y); 
                
                }
                else
                {
                    spawnObj(dirt, x, y);
                }
                
                
            }
           // Instantiate (grass, new Vector2 (x, height ), Quaternion.identity);

            spawnObj(grass, x, height);
        }
    }
    //makes spawned blocks be child of procedural generation gameobject
    void spawnObj(GameObject obj, int widtch, int height )
    {
        obj = Instantiate(obj, new Vector2(widtch, height), Quaternion.identity);
        obj.transform.parent = this.transform;
    }
}
