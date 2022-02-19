using MyFirstMLApp;

//Load sample data
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = @"My go to place from now on",
};

//Load model and predict output
var result = SentimentModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
string sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");