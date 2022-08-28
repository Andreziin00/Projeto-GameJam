using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Tile.../Animated Tile", fileName = "New anim tile")]
public class AnimTile: TileBase
{
 public Sprite[] sprites;

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        if(sprites != null && sprites.Length > 0)
        {
         tileData.sprite = sprites[0];
        }
    }

    public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
    {
        if(sprites.Length > 0)
        {
         tileAnimationData.animatedSprites = sprites;
         tileAnimationData.animationSpeed = 1;
         tileAnimationData.animationStartTime = 0;
         return true;
        }
        return false;
    }
}
