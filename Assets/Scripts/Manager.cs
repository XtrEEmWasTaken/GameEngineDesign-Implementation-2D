using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public int coinCount = 0;
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
        Debug.Log("Coin Count: " + coinCount);
    }
}
