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
    public static int scriptCount = 6;
    public bool isSetFalseAlready;
    // Start is called before the first frame update
    void Start()
    {

        instruction = GameObject.Find("ball1");

        textToTeach = GameObject.Find("textToTeach").GetComponent<TextMeshProUGUI>();
        scriptsRun++;
        print(scriptsRun);
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptsRun >= scriptCount && !isSetFalseAlready)
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
            case "ballOfBeginning":
                setGreen();
                textToTeach.text = "Welcome to the Terrain game! \nFollow the balls of knowledge in the game to learn about the terrain tools in Unity! \n\nThe balls are in order, so make sure to check the ball number at the top left when reading it to know that you are following the steps correctly!\n\nSome of the balls may be hidden, but you must follow the balls in order! Have fun!";
                break;
            case "ballOfKnowledge":
                SetNormColor();
                textToTeach.text = "0. Click \nplus sign > 3D object > terrain \nto create a terrain. Move it to the side";
                break;
            case "ballOfKnowledge (1)":
                SetNormColor();
                textToTeach.text = "1. To edit terrain size, click on the terrain, go to the terrain game component, and click the 5th icon. \n\nScroll down until you find \"terrain width and length\", and make the size of the terrain 200 by 200.";
                break;
            case "ballOfKnowledge (2)":
                SetNormColor();
                textToTeach.text = "2. Going to the second icon in the terrain game component allows you to paint terrain, raise or lower terrain, set height, etc. \n\nAdd mountains to your terrain by going to \"raise and lower terrain\", choosing a brush, setting the brush strength to around 0.02, setting a brush size, and then draw!";
                break;
            case "ballOfKnowledge (3)":
                SetNormColor();
                textToTeach.text = "3. Try the first icon in the terrain game component to create neighbor terrain to create 3 more terrain surrounding the terrain";
                break;
            case "ballOfKnowledge (4)":
                SetNormColor();
                textToTeach.text = "4. P.S. You are allowed to move the \"Player Man\" (see hierarchy) forwards as you work on your terrain in between game sessions.\n\nGo to the second icon again, and find the paint texture option. Scroll down and add a layer, choose one different from the colors of this game.\nThen add another layer, mess around with the settings, and paint your terrain with it.";
                break;
            case "ballOfKnowledge (5)":
                SetNormColor();
                textToTeach.text = ".";
                break;


        }

    }
    private void setGreen()
    {
        textToTeach.color = new Color(0.35f, 0.97f, 0.22f);
    }
    private void SetNormColor()
    {
        textToTeach.color = new Color(0.7f, 0.18f, 0.9f);
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
