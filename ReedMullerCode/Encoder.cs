using System.Collections.Generic;

namespace ReedMullerCode
{
    public class Encoder
    {
        public static int GetExpectedVectorLength(int m)
        {
            return m + 1;
        }

        public static List<int> EncodeVector(List<int> vector, int m)
        {
            return GeneratorMatrix.MultiplyByGeneratorMatrix(m, vector);
        }
    }
}