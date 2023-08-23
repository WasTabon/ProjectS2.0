using UnityEngine;

public class GymStats : MonoBehaviour
{
    public ObservableVariable<int> Bench { get; private set; }
    public ObservableVariable<int> Squat { get; private set; }
    public ObservableVariable<int> DeadLift { get; private set; }

    private void Awake()
    {
        Bench = new ObservableVariable<int>(0);
        Squat = new ObservableVariable<int>(0);
        DeadLift = new ObservableVariable<int>(0);
    }
}
