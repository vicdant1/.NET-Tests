using System.Collections;

namespace GenericClassLib
{
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            for(int i = 0; i < 10; i++)
                yield return new object[] { i, i+1, i-1};

            yield return new object[] {20, 10, 10};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
