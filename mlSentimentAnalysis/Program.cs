// See https://aka.ms/new-console-template for more information
//Load sample data
using MlSentimentAnalysis;

var sampleData = new SentimentAnalysis.ModelInput()
{
    Col0 = @"This is the worst experience I've ever had.",
};

//Load model and predict output
var result = SentimentAnalysis.Predict(sampleData);
Console.WriteLine( result.ToString());
