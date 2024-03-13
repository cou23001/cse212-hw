// Represents a collection of earthquake features.
public class FeatureCollection {

    // Gets or sets the list of earthquake features.
    public List<Feature> Features { get; set; }
}

// Represents an earthquake feature.
public class Feature
{
    // Gets or sets the properties of the earthquake feature.
    public Properties Properties { get; set; }
}

// Represents the properties of an earthquake.
public class Properties
{
    // Gets or sets the magnitude of the earthquake.
    public double Mag { get; set; }

    // Gets or sets the location of the earthquake.
    public string Place { get; set; }
}