using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsMenu : MonoBehaviour
{
    public GameObject Instructions;
    public static bool instructionsUp;
    // Start is called before the first frame update
    void Start()
    {
        Instructions.SetActive(false);
        instructionsUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (instructionsUp)
            {
                exitCredits();
            }
        }
    }

    public void viewCredits()
    {
        Instructions.SetActive(true);
        instructionsUp = true;
    }

    public void exitCredits()
    {
        Instructions.SetActive(false);
        instructionsUp = false;
    }
}
