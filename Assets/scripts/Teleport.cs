using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Teleport : MonoBehaviour
{
    public Transform playerLocation;
    public static FirstPersonController playerScript;
    public GameObject restartButt;
    public Button restartButton;
    public static bool ButtonFound = false;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("PlayerMan").GetComponent<FirstPersonController>();
        if (!ButtonFound)
        {
            
            restartButt.SetActive(false);
            ButtonFound = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerMan")
        {
            switch (name) {
                case "ballOfTeleportation":
                    playerLocation.position = new Vector3(48.7f, 25.63f, 103);
                    break;
                case "ballOfTeleportation (1)":
                    restartButt.SetActive(true);
                    playerScript.enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                    break;

            }
        }
    }
    public void restartLevel()
    {
        ButtonFound = false;
        SceneManager.LoadScene("FullGame");
        
    }
}
