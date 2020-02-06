using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public Text text;

    public float forwardForce = 2000f;

    private Controller m_PlayerReceiver;

	// Use this for initialization
	void Start () {
        m_PlayerReceiver = new PlayerReceiver();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") ) {
            Command commandRight = new MoveRight(m_PlayerReceiver, rb, text);
            Invoker invoker = new Invoker();
            invoker.SetCommand(commandRight);
            invoker.ExecuteCommand();

        }

        if (Input.GetKey("a"))
        {
            Command commandLeft = new MoveLeft(m_PlayerReceiver, rb, text);
            Invoker invoker = new Invoker();
            invoker.SetCommand(commandLeft);
            invoker.ExecuteCommand();
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
