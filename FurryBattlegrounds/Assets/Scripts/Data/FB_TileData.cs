using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "NewTileData", menuName = "FB Data/TileData")]
public class FB_TileData : FB_IData
{
    public string Serialize()
    {
        return "return {}";
    }

    public bool Deserialize(string LuaCode)
    {


        return true;
    }
}
