using UnityEngine;
using TMPro;
public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public int coinCount = 0;
    public TextMeshProUGUI coinText;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coinCount++;
        coinText.text = "Coins: " + coinCount;
        Debug.Log("Coin Count: " + coinCount);
    }
}
