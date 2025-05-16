using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UISpeed : MonoBehaviour
{
    public TMP_Text velocidade;
    // Start is called before the first frame update
    

    public void Velocidadetxt(float speed)
    {
        velocidade.text = "speed " + speed + "/5";
    }
}
