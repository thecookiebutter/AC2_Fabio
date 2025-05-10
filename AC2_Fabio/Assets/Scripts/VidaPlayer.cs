using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public GameObject Explosao;

    private void Start()
    {
        GameManager.Instance.PlayerMorre.AddListener(Morte);
    }
    public void Morte()
    {
        Instantiate(Explosao, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        GameManager.Instance.PlayerMorre.RemoveListener(Morte);
    }
}
