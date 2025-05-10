using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public UnityEvent PlayerMorre;

    public UnityEvent<float> Checklanding;

    public UnityEvent PlayerWin;

    private void Awake()
    {
        Instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        PlayerWin.AddListener(Win);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        Debug.Log("Win");
    }
}
