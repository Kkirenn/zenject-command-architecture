using UnityEngine;
using Zenject;

public class AddCoinsCommand : ICommand
{
    private readonly WalletService _walletService;
    private readonly int _amount;

    public AddCoinsCommand(WalletService walletService, int amount)
    {
        _walletService = walletService;
        _amount = amount;
    }

    public void Execute()
    {
        _walletService.AddCoins(_amount);
        Debug.Log($"+ {_amount} coins");
    }

    public class Factory : PlaceholderFactory<int, AddCoinsCommand> { }
}
