using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMusic : MonoBehaviour
{
    private static InGameMusic inGameMusic;

    void Awake()
    {
        if (inGameMusic == null){
            inGameMusic = this;
        }

        else {
            Destroy(gameObject);
        }
    }
}
