using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToPortrait = true;
        Screen.orientation = ScreenOrientation.Portrait;
    }

}
