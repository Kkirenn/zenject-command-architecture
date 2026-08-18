using Cysharp.Threading.Tasks;
using System;
using UniRx;
using UnityEngine;

public class WalletService
{
    private readonly IntReactiveProperty _coins = new IntReactiveProperty(0);
    public IReadOnlyReactiveProperty<int> Coins => _coins;

    public void AddCoins(int amount)
    {
        _coins.Value += amount;
    }


    public async UniTask SaveProgressAsync()
    {
        try
        {
            await UniTask.Delay(TimeSpan.FromSeconds(1.5f));

            Debug.Log($"Current balance: {_coins.Value}");
        }
        catch (Exception exception)
        {
            Debug.LogError($"Error: {exception.Message}");
        }
    }
}
