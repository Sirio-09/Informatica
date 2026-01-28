namespace tests
{
    public class IOTests : IDisposable
    {
        private StringWriter _stdOutMock;

        private TextReader _stdIn;
        private TextWriter _stdOut;

        public IOTests()
        {
            this._stdIn = Console.In;
            this._stdOut = Console.Out;

            this._stdOutMock = new StringWriter();

            Console.SetOut(_stdOutMock);
        }

        // [Fact(DisplayName = "Case 5 - INPUT: 1111")]
        // public void Test5()
        // {
        //     const string input = "1111";
        //     const string expectedOutput = "Il perimetro del quadrato � 4444\nL'area del quadrato � 1234321\n";

        //     this.IOTest(input, expectedOutput);
        // }

        private void IOTest(string input, string expectedOutput)
        {
            // Mock input
            StringReader stdInMock = new StringReader(input);
            Console.SetIn(stdInMock);

            string[] args = { "" };
            lesson.Program.Main(args);
            this._stdOutMock.Flush();

            var actualOutputLines = this._stdOutMock.ToString().Trim();
            var parsedExpectedOutput = expectedOutput.ReplaceLineEndings().Trim();

            Assert.Contains(actualOutputLines, parsedExpectedOutput);
        }

        public void Dispose()
        {
            Console.SetIn(this._stdIn);
            Console.SetOut(this._stdOut);

            this._stdOutMock.Dispose();
        }
    }
}