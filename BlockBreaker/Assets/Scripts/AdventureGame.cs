using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Use this for init
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();  
    }

    // Update is called once per frame
    void Update () 
    {
       ManageState(); 
    }
    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
                if(Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
            textComponent.text = state.GetStateStory();
        }
          // The section below checks for key presses, but theres a bug.      
    /*    if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
*/
    }
}


       
    

