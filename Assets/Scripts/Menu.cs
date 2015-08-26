using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {



    private int window = 0;
    void Start()
    {

    }
    void Update()
    {

    }
    void OnGUI()
    {
        switch (window)
        {
            case 0:
                GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 180), "Главное меню");
                if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 40, 180, 30), "Новая игра"))
                {
                    window = 1;
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2, 180, 30), "Настройки"))
                {
                    window = 2;
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 40, 180, 30), "Выход"))
                {
                    Application.Quit();
                }
                break;
            case 1:
                GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 180), "Выбор карты");
                if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 80, 180, 30), "Развилка") )
                {
                    Application.LoadLevel(2);
                } else
                if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 40, 180, 30), "Перекресток"))
                {
                    Application.LoadLevel(1);
                }else
                if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 40, 180, 30), "Назад") || Input.GetKeyDown(KeyCode.Escape))
                {
                    window = 0;
                }
                break;
            case 2:
                GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 180), "Настройки");
                if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 40, 180, 30), "Назад") || Input.GetKeyDown(KeyCode.Escape))
                {
                    window = 0;
                }
                break;
        }
    }

}
