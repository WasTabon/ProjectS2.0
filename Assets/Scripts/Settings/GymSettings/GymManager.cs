using UnityEngine;
using Zenject;

public class GymManager : ObservableLogger
{
    private int _generalStats;
    private int _selfEsteem;

    private GymStats _gymStats;
    
    public int GeneralStats
    {
        get => _generalStats;
        set
        {
            _generalStats = value;
        }
    }
    public int SelfEsteem
    {
        get => _selfEsteem;
        set
        {
            _selfEsteem = value;
        }
    }
    
    [Inject]
    private void Construct(GymStats gymStats)
    {
        _gymStats = gymStats;
    }
    
    private void Start()
    {
        Debug.Log($"Manager stats: {_gymStats.gameObject.name}");
        AddObservable(_gymStats.Bench);
        AddObservable(_gymStats.Squat);
        AddObservable(_gymStats.DeadLift);
    }

    private void UpdateGymStats()
    {
        GeneralStats = (_gymStats.Bench.Value + _gymStats.Squat.Value);
        SelfEsteem = _gymStats.DeadLift.Value;
    }
    
    protected override void OnChanged(object obj)
    {
        Debug.Log($"New GymStats - {GeneralStats}, SelfEsteem - {_selfEsteem}");
        UpdateGymStats();
    }
}
