using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<WalletService>().AsSingle().NonLazy();
        Container.Bind<CommandService>().AsSingle().NonLazy();

        Container.BindFactory<int, AddCoinsCommand, AddCoinsCommand.Factory>();
    }
}
