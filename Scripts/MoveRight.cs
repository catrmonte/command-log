using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRight : Command
{
    public float sidewaysForce = 100f;

    public MoveRight(Controller controller, Rigidbody rb, Text text) : base(controller)
    {
        text.text = "Moving Right";
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public override void Execute()
    {
        m_controller.MoveRight();
    }
}
