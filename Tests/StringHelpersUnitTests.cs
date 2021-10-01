using DotNetLab1;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Tests
{
    public class StringHelpersUnitTests
    {
        [Fact]
        public void StringHelpersComputeWordsFromSentenceEmptyString()
        {
            var text = "";

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Empty(words);
        }

        [Fact]
        public void StringHelpersComputeWordsFromSentenceBlankString()
        {
            var text = "              ";

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Empty(words);
        }


        [Fact]
        public void StringHelpersComputeWordsFromSentenceNullString()
        {
            var text = default(string);

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Empty(words);
        }

        [Fact]
        public void StringHelpersComputeWordsFromSentenceOneWord()
        {
            var text = "default";

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Single(words);
            Assert.Equal("default", words[0]);
        }

        [Fact]
        public void StringHelpersComputeWordsFromSentenceOneWordSpacedOut()
        {
            var text = "      default                ";

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Single(words);
            Assert.Equal("default", words[0]);
        }

        [Fact]
        public void StringHelpersComputeWordsFromSentenceUsualSentence()
        {
            var text = " this is  a      random-request";

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Equal(4, words.Count);
            Assert.Equal("this", words[0]);
            Assert.Equal("is", words[1]);
            Assert.Equal("a", words[2]);
            Assert.Equal("random-request", words[3]);
        }


        [Fact]
        public void StringHelpersComputeWordsFromSentenceLargeSentence()
        {
            var watch = new Stopwatch();

            watch.Start();

            var text = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
";

            List<string> words = text.ComputeWordsFromSentence();

            watch.Stop();

            var millisecondsAmount = watch.ElapsedMilliseconds;

            Assert.Equal(1092, words.Count);
            Assert.True(millisecondsAmount <= 10);
        }


        [Fact]
        public void StringHelpersComputeWordsFromSentenceNewLinesEmpty()
        {
            var text = "\n\n\n\n\n\n\n    \n \n \n \r \r \n";

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Empty(words);
        }


        [Fact]
        public void StringHelpersComputeWordsFromSentenceAllTestCasesCombined()
        {
            var text = "Lorem#    \r  Ipsum. is;     \n simply?     dummy   \r\n .";

            List<string> words = text.ComputeWordsFromSentence();

            Assert.Equal(5, words.Count);
            Assert.Equal("Lorem", words[0]);
            Assert.Equal("Ipsum", words[1]);
            Assert.Equal("is", words[2]);
            Assert.Equal("simply", words[3]);
            Assert.Equal("dummy", words[4]);
        }

    }
}
