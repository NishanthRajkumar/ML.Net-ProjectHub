using PredictiveMaintenance;

//Load sample data
var sampleData = new PredictiveMaintenanceModel.ModelInput()
{
    UDI = 2F,
    Product_ID = @"L47340",
    Type = @"L",
    Air_temperature = 298.4F,
    Process_temperature = 308.2F,
    Rotational_speed = 1282F,
    Torque = 60.7F,
    Tool_wear = 216F,
    TWF = 0F,
    HDF = 0F,
    PWF = 0F,
    OSF = 0F,
    RNF = 0F,
};

//Load model and predict output
var result = PredictiveMaintenanceModel.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Machine_failure with predicted Machine_failure from sample data...\n\n");


Console.WriteLine($"UDI: {2F}");
Console.WriteLine($"Product_ID: {@"L47181"}");
Console.WriteLine($"Type: {@"L"}");
Console.WriteLine($"Air_temperature: {298.2F}");
Console.WriteLine($"Process_temperature: {308.7F}");
Console.WriteLine($"Rotational_speed: {1408F}");
Console.WriteLine($"Torque: {46.3F}");
Console.WriteLine($"Tool_wear: {3F}");
Console.WriteLine($"Machine_failure: {0F}");
Console.WriteLine($"TWF: {0F}");
Console.WriteLine($"HDF: {0F}");
Console.WriteLine($"PWF: {0F}");
Console.WriteLine($"OSF: {0F}");
Console.WriteLine($"RNF: {0F}");


Console.WriteLine($"\n\nPredicted Machine_failure: {result.PredictedLabel}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();