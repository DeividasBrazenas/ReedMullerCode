using System.Collections.Generic;

namespace ReedMullerCode
{
    public interface IGeneratorMatrix
    { 
        List<int> MultiplyByGeneratorMatrix(List<int> vector);
    }
}