using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileData : MonoBehaviour
{
    public Tilemap tilemap;

    // todo internal reresentation

    // Start is called before the first frame update
    void Start()
    {
        // todo spawn new city at 0,0
        // todo generate map
        // todo spawn new city randomly
    }

    public bool placeTile(int x, int y)
    {
        // todo checks if tile is empty and, if possible, places a rail tile there
    } 

    public bool deleteTile(int x, int y)
    {
        // todo spawns a delete call that deletes all invalid tracks found from the given point
    }
}
