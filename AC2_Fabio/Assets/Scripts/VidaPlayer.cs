using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public GameObject Explosao;
    

    public void Morte()
    {
        Instantiate(Explosao, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
