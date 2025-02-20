﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Samples
{
    public partial class TextAnalyticsSamples
    {
        [Test]
        public async Task AnalyzeSentimentAsync()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(apiKey), CreateSampleOptions());

            string document = @"I had the best day of my life. I decided to go sky-diving and it
                                made me appreciate my whole life so much more.
                                I developed a deep-connection with my instructor as well, and I
                                feel as if I've made a life-long friend in her.";

            try
            {
                Response<DocumentSentiment> response = await client.AnalyzeSentimentAsync(document);
                DocumentSentiment docSentiment = response.Value;

                Console.WriteLine($"Sentiment was {docSentiment.Sentiment}, with confidence scores: ");
                Console.WriteLine($"  Positive confidence score: {docSentiment.ConfidenceScores.Positive}.");
                Console.WriteLine($"  Neutral confidence score: {docSentiment.ConfidenceScores.Neutral}.");
                Console.WriteLine($"  Negative confidence score: {docSentiment.ConfidenceScores.Negative}.");
            }
            catch (RequestFailedException exception)
            {
                Console.WriteLine($"Error Code: {exception.ErrorCode}");
                Console.WriteLine($"Message: {exception.Message}");
            }
        }
    }
}
