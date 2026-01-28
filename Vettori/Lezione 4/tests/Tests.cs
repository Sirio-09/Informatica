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

        #region Examples
        [Fact(DisplayName="Example 1 - CHOICE: -1, NO INPUT")]
        public void TestExample()
        {
            const string input = "-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 2 - CHOICE: 1, SIZE: -1")]
        public void TestExample2()
        {
            const string input = "1\n-1";
            const string expectedOutput = "Inserisci una dimensione maggiore di 0";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 3 - CHOICE: 1, SIZE: 2, ARRAY: 10 5 ")]
        public void TestExample3()
        {
            const string input = "1\n2\n10\n5";
            const string expectedOutput = "10 5";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 4 - CHOICE: 2, SIZE: 5, ARRAY: 10 5 1 4 5")]
        public void TestExample4()
        {
            const string input = "2\n5\n10\n5\n1\n4\n5";
            const string expectedOutput = "10 1 5";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 5 - CHOICE: 3, SIZE: 5, ARRAY: 10 5 1 4 5")]
        public void TestExample5()
        {
            const string input = "3\n5\n10\n5\n1\n4\n5";
            const string expectedOutput = "5,4";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 6 - CHOICE: 4, SIZE: 5, ARRAY: 1 2 3 4 5")]
        public void TestExample6()
        {
            const string input = "4\n5\n1\n2\n3\n4\n5";
            const string expectedOutput = "L'array è ordinato in modo crescente";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 7 - CHOICE: 5, SIZE: 5, ARRAY: 5 4 3 2 1")]
        public void TestExample7()
        {
            const string input = "5\n5\n5\n4\n3\n2\n1";
            const string expectedOutput = "L'array è ordinato in modo decrescente";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 8 - CHOICE: 6, SIZE: 5, ARRAY: 1 2 3 4 5, INPUT NUMBER: 4")]
        public void TestExample8()
        {
            const string input = "6\n5\n1\n2\n3\n4\n5\n4";
            const string expectedOutput = "Il numero 4 compare 1 volta nel vettore 1 2 3 4 5";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 9 - CHOICE: 6, SIZE: 5, ARRAY: 3 3 3 4 5, INPUT NUMBER: 3")]
        public void TestExample9()
        {
            const string input = "6\n5\n1\n2\n3\n4\n5\n4";
            const string expectedOutput = "Il numero 3 compare 3 volte nel vettore 3 3 3 4 5";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Example 10 - CHOICE: 6, SIZE: 5, ARRAY: 9 2 3 4 5, INPUT NUMBER: 1")]
        public void TestExample10()
        {
            const string input = "6\n5\n9\n2\n3\n4\n5\n1";
            const string expectedOutput = "Il numero 1 non compare nel vettore 9 2 3 4 5";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Bad Array size tests
        [Fact(DisplayName = "Case 1 - CHOICE: 7, NO INPUT")]
        public void Test1()
        {
            const string input = "7";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 2 - CHOICE: 17, NO INPUT")]
        public void Test2()
        {
            const string input = "7";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 3 - CHOICE: 2, SIZE: -1")]
        public void Test3()
        {
            const string input = "2\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 4 - CHOICE: 3, SIZE: -1")]
        public void Test4()
        {
            const string input = "3\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 5 - CHOICE: 4, SIZE: -1")]
        public void Test5()
        {
            const string input = "4\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 6 - CHOICE: 5, SIZE: -1")]
        public void Test6()
        {
            const string input = "5\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 7 - CHOICE: 6, SIZE: -1")]
        public void Test7()
        {
            const string input = "6\n-1";
            const string expectedOutput = "Scelta non valida";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Tests CHOICE 1
        [Fact(DisplayName = "Case 8 - CHOICE: 1, SIZE: 2, ARRAY: 1 1")]
        public void Test8()
        {
            const string input = "1\n2\n1\n1";
            const string expectedOutput = "1 1";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 9 - CHOICE: 1, SIZE: 3, ARRAY: 1 2 3")]
        public void Test9()
        {
            const string input = "1\n3\n1\n2\n3";
            const string expectedOutput = "1 2 3";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 10 - CHOICE: 1, SIZE: 10, ARRAY: 1 10 100 1000 2 20 200 2000 3 30")]
        public void Test10()
        {
            const string input = "1\n10\n1\n10\n100\n1000\n2\n20\n200\n2000\n3\n30";
            const string expectedOutput = "1 10 100 1000 2 20 200 2000 3 30";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Tests CHOICE 2
        [Fact(DisplayName = "Case 11 - CHOICE: 2, SIZE: 2, ARRAY: 1 1")]
        public void Test11()
        {
            const string input = "2\n2\n1\n1";
            const string expectedOutput = "1";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 12 - CHOICE: 2, SIZE: 3, ARRAY: 1 2 3")]
        public void Test12()
        {
            const string input = "2\n3\n1\n2\n3";
            const string expectedOutput = "1 3";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 13 - CHOICE: 2, SIZE: 10, ARRAY: 1 10 100 1000 2 20 200 2000 3 30")]
        public void Test13()
        {
            const string input = "2\n10\n1\n10\n100\n1000\n2\n20\n200\n2000\n3\n30";
            const string expectedOutput = "1 100 2 200 3";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Tests CHOICE 3
        [Fact(DisplayName = "Case 14 - CHOICE: 3, SIZE: 2, ARRAY: 1 1")]
        public void Test14()
        {
            const string input = "3\n2\n1\n1";
            const string expectedOutput = "1";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 15 - CHOICE: 3, SIZE: 3, ARRAY: 1 2 3")]
        public void Test15()
        {
            const string input = "3\n3\n1\n2\n3";
            const string expectedOutput = "2";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 16 - CHOICE: 3, SIZE: 10, ARRAY: 1 10 100 1000 2 20 200 2000 3 30")]
        public void Test16()
        {
            const string input = "3\n10\n1\n10\n100\n1000\n2\n20\n200\n2000\n3\n30";
            const string expectedOutput = "10 1000 20 2000 30";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Tests CHOICE 4
        [Fact(DisplayName = "Case 17 - CHOICE: 4, SIZE: 2, ARRAY: 1 1")]
        public void Test17()
        {
            const string input = "4\n2\n1\n1";
            const string expectedOutput = "1 1";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 18 - CHOICE: 4, SIZE: 10, ARRAY: 1 10 100 1000 2 20 200 2000 3 30")]
        public void Test18()
        {
            const string input = "4\n10\n1\n10\n100\n1000\n2\n20\n200\n2000\n3\n30";
            const string expectedOutput = "30 3 2000 200 20 2 1000 100 10 1";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Tests CHOICE 5
        [Fact(DisplayName = "Case 19 - CHOICE: 5, SIZE: 10, ARRAY: 1 10 100 1000 2 20 200 2000 3 30")]
        public void Test19()
        {
            const string input = "5\n10\n1\n10\n100\n1000\n2\n20\n200\n2000\n3\n30";
            const string expectedOutput = "L'array non è ordinato";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 20 - CHOICE: 5, SIZE: 4, ARRAY: 1 10 100 1000")]
        public void Test20()
        {
            const string input = "5\n4\n1\n10\n100\n1000";
            const string expectedOutput = "L'array è ordinato in modo crescente";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 21 - CHOICE: 5, SIZE: 7, ARRAY: 999 888 777 66 5 4 3")]
        public void Test21()
        {
            const string input = "5\n7\n999\n888\n777\n66\n5\n4\n3";
            const string expectedOutput = "L'array è ordinato in modo decrescente";

            this.IOTest(input, expectedOutput);
        }
        #endregion

        #region Tests CHOICE 6
        [Fact(DisplayName = "Case 22 - CHOICE: 6, SIZE: 4, ARRAY: 1 10 100 1000, INPUT NUMBER: 10")]
        public void Test22()
        {
            const string input = "6\n4\n1\n10\n100\n1000\n10";
            const string expectedOutput = "Il numero 10 compare 1 volta nel vettore 1 10 100 1000";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 23 - CHOICE: 6, SIZE: 5, ARRAY: 1 1 100 1000 10, INPUT NUMBER: 1")]
        public void Test23()
        {
            const string input = "6\n5\n1\n1\n100\n1000\n10\n1";
            const string expectedOutput = "Il numero 1 compare 2 volte nel vettore 1 1 100 1000 10";

            this.IOTest(input, expectedOutput);
        }

        [Fact(DisplayName = "Case 24 - CHOICE: 6, SIZE: 5, ARRAY: 9 99 87 64 123, INPUT NUMBER: 86")]
        public void Test24()
        {
            const string input = "6\n5\n9\n99\n87\n64\n123\n86";
            const string expectedOutput = "Il numero 86 non compare nel vettore 9 99 87 64 123";

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

            Assert.NotEmpty(actualOutputLines);
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