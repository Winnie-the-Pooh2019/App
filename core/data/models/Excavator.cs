namespace App.core.data.models; 

public class Excavator {
    public int id { get; private set; }
    public string modelName { get; private set; }
    public double bucketVolume { get; private set; }
    public double maxHeight { get; private set; }
    public int loopTime { get; private set; }
    public int powerRotor { get; private set; }
}