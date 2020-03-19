using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI;
    public ItemBox[] itemBoxes;

    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main"); // "Main" 대신 순번, 즉 0 을 넣어도 상관 없음.
        }

        if (isGameOver)
            return;

        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if (itemBoxes[i].isOveraped)
            {
                count++;
            }
            else
                break;
        }

        if(count >= 3)
        {
            Debug.Log("게임 승리");
            isGameOver = true;
            winUI.SetActive(true);
        }
    }
}
