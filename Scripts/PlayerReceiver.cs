using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReceiver : Controller
{
    public override void MoveLeft()
    {
        Debug.Log("Move Left");
    }

    public override void MoveRight()
    {
        Debug.Log("Move Right");
    }
}
