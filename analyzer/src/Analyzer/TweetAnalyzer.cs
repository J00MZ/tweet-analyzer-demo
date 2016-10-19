using Analyzer.Model;

namespace Analyzer
{
    class TweetAnalyzer
    {
        public AnalyzedTweet Analyze(Tweet tweet)
        {
            return new AnalyzedTweet
            {
                Text = tweet.Text,
                Sentiment = Sentiment.Neutral
            };
        }
    }
}