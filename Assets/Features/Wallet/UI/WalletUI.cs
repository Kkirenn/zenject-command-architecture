using UnityEngine;
using Zenject;
using UniRx;
using TMPro;

public class WalletUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsText;
    private WalletService _walletService;

    [Inject]
    public void Construct(WalletService walletService)
    {
        _walletService = walletService;
    }

    private void Start()
    {
        _walletService.Coins
            .Subscribe(currentCoins =>
            {
                _coinsText.text = $"Coins: {currentCoins}";
            }).AddTo(this);
    }
}
