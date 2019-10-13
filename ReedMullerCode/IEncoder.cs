using System.Collections.Generic;

namespace ReedMullerCode
{
    public interface IEncoder
    {
        List<int> EncodeVector(List<int> vector);
    }
}