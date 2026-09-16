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

        #region Example Tests
        [Fact(DisplayName="Example 1 - CHOICE -1, NO INPUT")]
        public void TestExample1()
        {
            const string input = "-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Example 2 - CHOICE 1, ARRAY SIZE: -1")]
        public void TestExample2()
        {
            const string input = "2\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Example 3 - CHOICE 1, ARRAY 1: 1 2 3, ARRAY 2: 1 2 3 4")]
        public void TestExample3()
        {
            const string input = "2\n3\n1\n2\n3\n4\n1\n2\n3\n4";
            const string expectedOutput = "Il vettore intersezione è 1 2 3";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Example 4 - CHOICE 1, ARRAY 1: 1 2 3, ARRAY 2: 9 8 7")]
        public void TestExample4()
        {
            const string input = "2\n3\n1\n2\n3\n3\n9\n8\n7";
            const string expectedOutput = "Il vettore intersezione è vuoto";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Example 5 - CHOICE 2, ARRAY 1: 5 3 66 7, ARRAY 2: 1 2 3 4 5")]
        public void TestExample5()
        {
            const string input = "2\n4\n5\n3\n66\n7\n5\n1\n2\n3\n4\n5";
            const string expectedOutput = "Il vettore unione è 5 3 66 7 1 2 4";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Example 6 - CHOICE 3, ARRAY 1: 1 2 3 4, ARRAY 2: 99 9 2 4 1")]
        public void TestExample6()
        {
            const string input = "3\n4\n1\n2\n3\n4\n5\n99\n9\n2\n4\n1";
            const string expectedOutput = "Il vettore differenza è 3";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Example 7 - CHOICE 3, ARRAY 1: 1 2, ARRAY 2: 1 2 3 4")]
        public void TestExample7()
        {
            const string input = "3\n2\n1\n2\n4\n1\n2\n3\n4";
            const string expectedOutput = "Il vettore differenza è vuoto";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Bad array size tests
        [Fact(DisplayName="Test 1 - CHOICE 1, ARRAY 2 SIZE: -1")]
        public void Test1()
        {
            const string input = "1\n3\n1\n2\n3\n-1";
            const string expectedOutput = "Inserisci una dimensione maggiore di 0";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Test 2 - CHOICE 2, ARRAY SIZE: -1")]
        public void Test2()
        {
            const string input = "2\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Test 3 - CHOICE 2, ARRAY 2 SIZE: -1")]
        public void Test3()
        {
            const string input = "2\n3\n1\n2\n3\n-1";
            const string expectedOutput = "Inserisci una dimensione maggiore di 0";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Test 4 - CHOICE 3, ARRAY SIZE: -1")]
        public void Test4()
        {
            const string input = "3\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Test 5 - CHOICE 3, ARRAY 2 SIZE: -1")]
        public void Test5()
        {
            const string input = "3\n3\n1\n2\n3\n-1";
            const string expectedOutput = "Inserisci una dimensione maggiore di 0";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Choice 1
        [Fact(DisplayName="Test 6 - CHOICE 3, ARRAY 1: 99 98 97 1 2 85, ARRAY 2: 99 1 2 191 100")]
        public void Test6()
        {
            const string input = "3\n6\n99\n98\n97\n1\n2\n85\n5\n99\n1\n2\n191\n100";
            const string expectedOutput = "Il vettore intersezione è 99 1 2";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Test 7 - CHOICE 3, ARRAY 1: 11 22 33, ARRAY 2: 1 2 3")]
        public void Test7()
        {
            const string input = "3\n6\n99\n98\n97\n1\n2\n85\n5\n99\n1\n2\n191\n100";
            const string expectedOutput = "Il vettore intersezione è vuoto";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Choice 2
        [Fact(DisplayName="Test 8 - CHOICE 2, ARRAY 1: 1 99 98, ARRAY 2: 11 22 33 44")]
        public void Test8()
        {
            const string input = "2\n3\n1\n99\n98\n4\n11\n22\n33\n44";
            const string expectedOutput = "Il vettore unione è 1 99 98 11 22 33 44";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Test 9 - CHOICE 2, ARRAY 1: 10 20 30, ARRAY 2: 10 30 20")]
        public void Test9()
        {
            const string input = "2\n3\n10\n20\n30\n3\n10\n30\n20";
            const string expectedOutput = "Il vettore unione è 10 20 30";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Choice 3
        [Fact(DisplayName="Test 10 - CHOICE 3, ARRAY 1: 10 20 30, ARRAY 2: 10 30 20")]
        public void Test10()
        {
            const string input = "3\n3\n10\n20\n30\n3\n10\n30\n20";
            const string expectedOutput = "Il vettore differenza è vuoto";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName="Test 11 - CHOICE 3, ARRAY 1: 10 20, ARRAY 2: 10 30")]
        public void Test11()
        {
            const string input = "3\n3\n10\n20\n2\n10\n30";
            const string expectedOutput = "Il vettore differenza è 20";

            this.IOTest(input, expectedOutput);
        }
        #endregion

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