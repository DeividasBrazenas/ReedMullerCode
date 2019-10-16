using System.Collections.Generic;

namespace ReedMullerCode.Encoder
{
    public interface IEncoder
    {
        List<int> Encode(List<int> vector);
    }
}