using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody playerRigid;
    public float playerJumpPower;
    // Start is called before the first frame update
    void Start()
    {
        playerJumpPower = 5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Player.transform.parent == gameObject.transform) {
            Player.transform.parent = null;
            print(Player.transform.parent);
            playerRigid.AddForce(0f, playerJumpPower, 0f, ForceMode.Impulse);
        }   
    }
    private void OnTriggerEnter(Collider other)
    {
        
            print(other.gameObject.name);
            other.gameObject.transform.parent = gameObject.transform;

    }
}
