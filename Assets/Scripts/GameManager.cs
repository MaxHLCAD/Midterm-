using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int winNum = 3;
    [SerializeField] private TextMeshProUGUI coinGUI;
    [SerializeField] private TextMeshProUGUI doorGUI;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private Door door;

    private int points = 0;

    void Awake()
    {
        points = 0;
        winScreen.SetActive(false);
    }    

    public void AddPoint()
    {
        points++;

        coinGUI.text = "Coins Collected: " + points + "/3";

        if (points >= winNum)
        {
            doorGUI.text = "Door Status: Unlocked";

            door.UnlockDoor();

            Debug.Log("Win Game!");
        }
    }

    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
    }
}
