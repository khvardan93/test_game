using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = System.Drawing.Color;

namespace Map
{
    public class Tile
    {
        public Tile(int xPos, int yPos)
        {
            Position = new Vector3Int(xPos, yPos, 0);
        }
        
        public Vector3Int Position;
        public int ColorIndex;
    }
}