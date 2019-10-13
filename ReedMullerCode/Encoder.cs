using System.Collections.Generic;

namespace ReedMullerCode
{
    public class Encoder : IEncoder
    {
        private readonly IGeneratorMatrix _generatorMatrix;

        public Encoder(int m)
        {
            _generatorMatrix = new GeneratorMatrix(m);
        }
        public List<int> EncodeVector(List<int> vector)
        {
            return _generatorMatrix.MultiplyByGeneratorMatrix(vector);
        }
    }
}