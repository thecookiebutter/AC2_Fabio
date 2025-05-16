using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaAterrisagem : MonoBehaviour
{
    public float velocidademax;
    void Start()
    {
        GameManager.Instance.Checklanding.AddListener(CheckLanding);
    }

    public void CheckLanding(float speed)
    {
        if (Mathf.Abs(speed) > velocidademax)
        {
            Debug.Log("morre");
            //GameManager.Instance.PlayerMorre.Invoke();
        }
        else
        {
            Debug.Log("win");
            GameManager.Instance.PlayerWin.Invoke();
        }
    }

    private void OnDestroy()
    {
        GameManager.Instance.Checklanding?.RemoveListener(CheckLanding);
    }

}
