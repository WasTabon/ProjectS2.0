using UnityEngine;
using Zenject;

public class StatsInstaller : MonoInstaller
{
    [SerializeField] private GymStats _gymStats;
    
    public override void InstallBindings()
    {
        Container.Bind<GymStats>().FromInstance(_gymStats).AsSingle().NonLazy();
        Container.Bind<LifeStats>().AsSingle();
    }
}