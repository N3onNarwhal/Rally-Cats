using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour
{
    public GameObject Credits;
    public static bool creditsUp;
    // Start is called before the first frame update
    void Start()
    {
        Credits.SetActive(false);
        creditsUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (creditsUp)
            {
                exitCredits();
            }
        }
    }

    public void viewCredits()
    {
        Credits.SetActive(true);
        creditsUp = true;
    }

    public void exitCredits()
    {
        Credits.SetActive(false);
        creditsUp = false;
    }
}
