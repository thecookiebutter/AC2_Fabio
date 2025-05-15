using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Win;
    public GameObject Lose;
    void Start()
    {
        GameManager.Instance.PlayerWin.AddListener(PlayerWin);
        GameManager.Instance.PlayerMorre.AddListener(PlayerLose);
    }

    public void PlayerWin()
    {
        Win.SetActive(true);
    }

    public void PlayerLose()
    {
        Lose.SetActive(true);
    }

    private void OnDestroy()
    {
        GameManager.Instance.PlayerWin?.RemoveListener(PlayerWin);
        GameManager.Instance.PlayerMorre?.RemoveListener(PlayerLose);
    }
}
