using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroDano : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.PlayerMorre.Invoke();
    }
}
