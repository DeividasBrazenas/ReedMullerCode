using System.Collections.Generic;

namespace ReedMullerCode.Decoder
{
    public interface IDecoder
    {
        List<int> Decode(List<int> bits);
    }
}