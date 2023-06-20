namespace App.core.data.models; 

public class UnitDustExcavator {
    public int id { get; private set; }
    public Excavator tool { get; private set; }
    public double dust { get; private set; }
    public string workingMod { get; private set; }
    public GroundTypes groundType { get; private set; }
}