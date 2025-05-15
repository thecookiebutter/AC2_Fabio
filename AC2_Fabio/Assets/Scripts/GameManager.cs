using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public UnityEvent PlayerMorre;

    public UnityEvent<float> Checklanding;

    public UnityEvent PlayerWin;

    public string proximafase;

    private void Awake()
    {
        Instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        PlayerMorre.AddListener(LoseReset);
    }

    // Update is called once per frame

    public void Win()
    {

        PlayerWin.Invoke();
        StartCoroutine("NextScene");
    }

    public void LoseReset()
    {
        ResetScene();
    }

    public IEnumerator NextScene()
    {
        yield return new WaitForSeconds (3.0f);
        SceneManager.LoadScene(proximafase);
    }

    public IEnumerator ResetScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Fase1");
    }
    private void OnDestroy()
    {
        PlayerMorre.RemoveListener(LoseReset);
    }
}
