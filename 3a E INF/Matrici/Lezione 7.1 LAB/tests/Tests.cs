using lesson;

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

        [Fact(DisplayName = "NewIntMatrixMirror")]
        public void TestNewIntMatrixMirror()
        {
            var testCaseMatrices = new int[][,]
            {
                new int[,]
                { },
                new int[,]
                {
                    { 1 },
                },
                new int[,]
                {
                    { 1, 2 },
                },
                new int[,]
                {
                    { 1, 2, 3, 4, 5 },
                },
                new int[,]
                {
                    { 1, 2 },
                    { 1, 2 },
                    { 1, 2 },
                },
                new int[,]
                {
                    { 1, 2 },
                    { 3, 4 },
                },
                new int[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                },
                new int[,]
                {
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                new int[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 },
                },
            };

            var testCaseMirrorRows = new bool[]
            {
                true,
                true,
                true,
                true,
                false,
                false,
                false,
                false,
                false
            };

            var expectedResults = new int[][,]
            {
                new int[,]
                { },
                new int[,]
                {
                    { 1 },
                },
                new int[,]
                {
                    { 2, 1 },
                },
                new int[,]
                {
                    { 5, 4, 3, 2, 1 },
                },
                new int[,]
                {
                    { 1, 2 },
                    { 1, 2 },
                    { 1, 2 },
                },
                new int[,]
                {
                    { 3, 4 },
                    { 1, 2 },
                },
                new int[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                },
                new int[,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                },
                new int[,]
                {
                    { 7, 8, 9 },
                    { 4, 5, 6 },
                    { 1, 2, 3 },
                },
            };

            for (int i = 0; i < expectedResults.Length; i++)
            {
                var testCaseMatrix = testCaseMatrices[i];
                var testCaseMirrorRowsValue = testCaseMirrorRows[i];
                var expectedResult = expectedResults[i];

                var actualResult = Program.NewIntMatrixMirror(testCaseMatrix, testCaseMirrorRowsValue);
                Assert.Equal(expectedResult, actualResult);
            }
        }

        [Fact(DisplayName = "NewIntMatrixDiagonalMirror")]
        public void TestNewIntMatrixDiagonalMirror()
        {
            var testCaseMatrices = new int[][,]
            {
                new int[,]
                { },
                new int[,]
                {
                    { 1 },
                },
                new int[,]
                {
                    { 3, 4 },
                    { 1, 2 },
                },
                new int[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                },
                new int[,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                },
                new int[,]
                {
                    { 7, 8, 9 },
                    { 4, 5, 6 },
                    { 1, 2, 3 },
                },
                new int[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 },
                },
            };

            var testCaseOnMainDiagonals = new bool[]
            {
                true,
                true,
                true,
                true,
                false,
                false,
                false
            };

            var expectedResults = new int[][,]
            {
                new int[,]
                { },
                new int[,]
                {
                    { 1 },
                },
                new int[,]
                {
                    { 3, 1 },
                    { 4, 2 },
                },
                new int[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                },
                new int[,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                },
                new int[,]
                {
                    { 3, 6, 9 },
                    { 2, 5, 8 },
                    { 1, 4, 7 },
                },
                new int[,]
                {
                    { 9, 6, 3 },
                    { 8, 5, 2 },
                    { 7, 4, 1 },
                },
            };

            for (int i = 0; i < expectedResults.Length; i++)
            {
                var testCaseMatrix = testCaseMatrices[i];
                var testCaseOnMainDiagonal = testCaseOnMainDiagonals[i];
                var expectedResult = expectedResults[i];

                var actualResult = Program.NewIntMatrixDiagonalMirror(testCaseMatrix, testCaseOnMainDiagonal);
                Assert.Equal(expectedResult, actualResult);
            }
        }

        [Fact(DisplayName = "NewIntMatrixRotation")]
        public void TestNewIntMatrixRotation()
        {
            var testCaseMatrices = new int[][,]
            {
                new int[,]
                { },
                new int[,]
                {
                    { 1 },
                },
                new int[,]
                {
                    { 1, 2 },
                    { 1, 2 },
                },
                new int[,]
                {
                    { 1, 2, 3 },
                    { 1, 2, 1 },
                    { 1, 2, 4 },
                },
                new int[,]
                {
                    { 1, 2 },
                    { 3, 4 },
                },
                new int[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                },
                new int[,]
                {
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                new int[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 },
                },
            };

            var testCaseRightRotations = new bool[]
            {
                true,
                true,
                true,
                true,
                false,
                false,
                false,
                false
            };

            var expectedResults = new int[][,]
            {
                new int[,]
                { },
                new int[,]
                {
                    { 1 },
                },
                new int[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                },
                new int[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 4, 1, 3 },
                },
                new int[,]
                {
                    { 2, 4 },
                    { 1, 3 },
                },
                new int[,]
                {
                    { 0, 0 },
                    { 0, 0 },
                },
                new int[,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                },
                new int[,]
                {
                    { 3, 6, 9 },
                    { 2, 5, 8 },
                    { 1, 4, 7 },
                },
            };

            for (int i = 0; i < expectedResults.Length; i++)
            {
                var testCaseMatrix = testCaseMatrices[i];
                var testCaseRightRotation = testCaseRightRotations[i];
                var expectedResult = expectedResults[i];

                var actualResult = Program.NewIntMatrixRotation(testCaseMatrix, testCaseRightRotation);
                Assert.Equal(expectedResult, actualResult);
            }
        }

        public void Dispose()
        {
            Console.SetIn(this._stdIn);
            Console.SetOut(this._stdOut);

            this._stdOutMock.Dispose();
        }
    }
}