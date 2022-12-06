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
        
        instruction.SetActive(true);
        switch (name)
        {
            case "ballOfBeginning":
                setGreen();
                textToTeach.text = "Welcome to the Terrain game! \nFollow the balls of knowledge in the game to learn about the terrain tools in Unity! \n\nThe balls are in order, so make sure to check the ball number at the top left when reading it to know that you are following the steps correctly!\n\nSome of the balls may be hidden, but you must follow the balls in order! Have fun!";
                break;
            case "ballOfKnowledge (-1)":
                SetNormColor();
                textToTeach.text = "0. Go to Window > Package Manager > Unity Registry. Scroll until you find terrain tools, and if it is not already installed, install it.";
                break;
            case "ballOfKnowledge":
                SetNormColor();
                textToTeach.text = "1. Click \nplus sign > 3D object > terrain \nto create a terrain.";
                break;
            case "ballOfKnowledge (1)":
                SetNormColor();
                textToTeach.text = "2. To edit terrain size, click on the terrain, go to the terrain game component, and click the 5th icon. \n\nScroll down until you find \"terrain width and length\", and make the size of the terrain 200 by 200.";
                break;
            case "ballOfKnowledge (2)":
                SetNormColor();
                textToTeach.text = "3. Try the first icon in the terrain game component to create 3 more neighbor terrain.";
                break;
            case "ballOfKnowledge (3)":
                SetNormColor();
                textToTeach.text = "4. Going to the second icon in the terrain game component allows you to paint terrain, raise or lower terrain, set height, etc. Find the paint texture option Scroll down and add a layer, choose one different from the colors of this game.\nThen add another layer, mess around with the settings, and paint your terrain with it.\n\nTry out different brushes and see how they impact your drawing!";
                break;
            case "ballOfKnowledge (4)":
                SetNormColor();
                textToTeach.text = "5. Go to the second icon and find set height. Set the height of all of your terrain to 30.";
                break;
            case "ballOfKnowledge (5)":
                SetNormColor();
                textToTeach.text = "6. Go to the second icon again, and find the raise and lower terrain option. \n\nAdd mountains to your terrain, choosing a brush, setting a low brush size, a brush strength, and any specific brush type. Add valleys and lower terrain by ctrl clicking. Then draw!";
                break;
            case "ballOfKnowledge (6)":
                SetNormColor();
                textToTeach.text = "7. The third icon allows you to give your terrain trees. Go to edit trees, and then choose a game object to act as your tree. \n\nAdd the tree, select it, edit the tree density and brush size to your liking, and try painting your terrain.";
                break;
            case "ballOfKnowledge (7)":
                SetNormColor();
                textToTeach.text = "8. This time, create your own game object in unity under an empty parent game object to act as your tree. Add materials, and design it however you want. Create a folder called prefabs and drag it into there. Then add it to your terrain using the tree tool. \n\n Remember, you can always increase your terrain size if it is too small.";
                break;
            case "ballOfKnowledge (8)":
                SetNormColor();
                textToTeach.text = "9. Go to the fourth option, where you can set grass textures and detail meshes. Add a grass texture, choose a texture, then click add. \n\nSelect your new texture and paint parts of the terrain with it, adjusting your opacity, brush size, etc.";
                break;
            case "ballOfKnowledge (9)":
                SetNormColor();
                textToTeach.text = "10. Try incorporating terraces into your terrain! In the 2nd icon, create mountains using the raise/lower terrain, and then go to Sculpt > Terrace and drag the brush over the mountains to create terraces.";
                break;
            case "ballOfKnowledge (10)":
                SetNormColor();
                textToTeach.text = "11. Want to flatten out your terrain at a certain height? Use the set height tool in the 2nd icon. Add leveled platforms of varying height on your terrain.";
                break;
            case "ballOfKnowledge (11)":
                SetNormColor();
                textToTeach.text = "12. To create a bridge between two parts/levels of terrain, go to the 2nd icon, Sculpt > Bridge. Follow the instructions in the inspector to create bridges between each of your platforms.";
                break;
            case "ballOfKnowledge (12)":
                SetNormColor();
                textToTeach.text = "**13** Congrats! You found the hidden ball! Find the end green ball to complete the game!";
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
