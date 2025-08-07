using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public static GameObject[] coins;
    public TextMeshProUGUI coinNum;
    private int coinsCollected;
    private GameObject player;
    [SerializeField] private ParticleSystem ps;
    private bool allCoinsCollected = false;

    void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin");
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        coinsCollected = PlayerInput.coinsCollected;
        coinNum.text = $"{coinsCollected}/{coins.Length}";
        if (coinsCollected == coins.Length && !allCoinsCollected)
        {
            allCoinsCollected = true;
            ps.Play();
        }
    }
}
