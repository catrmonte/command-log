using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveLeft : Command
{
    public float sidewaysForce = 100f;

    public MoveLeft(Controller controller, Rigidbody rb, Text text) : base(controller)
    {
        text.text = "Moving Left";
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public override void Execute()
    {
        m_controller.MoveLeft();
    }
}
