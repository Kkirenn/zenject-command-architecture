using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class RewardedAdButton : MonoBehaviour
{
    [SerializeField] private Button _adButton;
    [SerializeField] private int _rewardAmount = 100;

    private CommandService _commandService;
    private AddCoinsCommand.Factory _addCoinsFactory;

    [Inject]
    public void Construct(CommandService commandService, AddCoinsCommand.Factory addCoinsFactory)
    {
        _commandService = commandService;
        _addCoinsFactory = addCoinsFactory;
    }

    private void Start()
    {
        _adButton.onClick.AddListener(OnAdWatched);
    }

    private void OnAdWatched()
    {
        var command = _addCoinsFactory.Create(_rewardAmount);
        _commandService.Execute(command);
    }
}
