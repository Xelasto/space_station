namespace Content.Server.Emp;

/// <summary>
/// Upon being triggered will EMP area around it.
/// </summary>
[RegisterComponent]
[Access(typeof(EmpSystem))]
public sealed partial class EmpOnCollideComponent : Component
{

    /// <summary>
    /// How much energy will be consumed per battery
    /// </summary>
    [DataField("energyConsumption"), ViewVariables(VVAccess.ReadWrite)]
    public float EnergyConsumption;

    /// <summary>
    /// How long it disables targets in seconds
    /// </summary>
    [DataField("disableDuration"), ViewVariables(VVAccess.ReadWrite)]
    public float DisableDuration = 60f;
}
