using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Button yourButton;
    //declare a boolean
    public bool buttonisclicked;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        //set to false on start, may not be necessary, I just can't remember if C# will return 1 or 0 for undefined booleans 
        buttonisclicked = false;
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        //set our bool to true
        buttonisclicked = true;
    }

    private void OnGUI()
    {
        //check if our button click boolean is true
        if (buttonisclicked)
        {
            //create gui menu, refer to linked documentation to learn how to create gui elements via script, and learn about various styling techniques
        }
    }
}
