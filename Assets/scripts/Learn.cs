using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Learn : MonoBehaviour
{
    public GameObject instruction;
    public TextMeshProUGUI textToTeach;
    public static int scriptsRun = 0;
    public bool isSetFalseAlready;
    
    // Start is called before the first frame update
    void Start()
    {

        instruction = GameObject.Find("ball1");

        textToTeach = GameObject.Find("textToTeach").GetComponent<TextMeshProUGUI>();
        scriptsRun++;
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptsRun >= 5 && !isSetFalseAlready)
        {
            instruction.SetActive(false);
            isSetFalseAlready = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        print(name);
        instruction.SetActive(true);
        switch (name)
        {
            case "ballOfKnowledge":
                textToTeach.text = "Click \n plus sign > 3D object > terrain \n to create a terrain";
                break;
            case "ballOfKnowledge (1)":
                textToTeach.text = "To edit terrain size, click on the terrain, go to the terrain game component, and click the 5th icon. \n Scroll down until you find \"terrain width and length\"";
                break;
            case "ballOfKnowledge (2)":
                textToTeach.text = "Going to the second icon in the terrain game component allows you to paint terrain, raise or lower terrain, set height, etc. \nTry the options you have with different brush sizes and opacities!";
                break;
            case "ballOfKnowledge (3)":
                textToTeach.text = "Try the first icon in the terrain game component to create neighbor terrain, which creates terrain located at one of the edges.";
                break;
            case "ballOfKnowledge (4)":
                textToTeach.text = ".";
                break;
            case "ballOfKnowledge (5)":
                textToTeach.text = ".";
                break;


        }

    }
    private void OnTriggerExit(Collider other)
    {
        instruction.SetActive(false);
    }
    //private IEnumerator Stop()
    //{
    //    return WaitForSeconds(5);
    //}
}
