using System.Collections.Generic;
using ReedMullerCode.Matrices;

namespace ReedMullerCode.Encoder
{
    public class Encoder : IEncoder
    {
        private readonly GeneratorMatrix _generatorMatrix;

        public Encoder(int m)
        {
            _generatorMatrix = new GeneratorMatrix(m);
        }
        public List<int> Encode(List<int> vector)
        {
            return _generatorMatrix.MultiplyByGeneratorMatrix(vector);
        }
    }
}