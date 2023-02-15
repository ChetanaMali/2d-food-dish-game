using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    [SerializeField] GameObject grid;
    public int count = 0;
    public Text uitext;
    public int vegcount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        count = grid.transform.childCount;
        Debug.Log(count);
        Time.timeScale = 0;

    }

    public void scorincrease()
    {
        vegcount++;
        uitext.text = vegcount.ToString();
    }

    public void winGame()
    {
        if (vegcount == (count - 1))
        {
            UIManeger.Instance.WinGame();
        }
    }
}
