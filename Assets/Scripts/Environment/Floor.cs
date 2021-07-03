using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts.Environment
{
    public class Floor : Tile
    {
        //GameObject contained on tile
        [NonSerialized]
        public GameObject content { get; set; }
    }
}
