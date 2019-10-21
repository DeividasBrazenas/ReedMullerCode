using System;
using System.Collections.Generic;
using System.Linq;
using ReedMullerCode.Matrices;

namespace ReedMullerCode.Decoder
{
    public class Decoder : IDecoder
    {
        private readonly int _m;

        public Decoder(int m)
        {
            _m = m;
        }

        public List<int> Decode(List<int> bits)
        {
            var wMatrices = new List<Matrix>();

            var replacedVector = bits.Select(x => x == 0 ? -1 : 1).ToList();
            wMatrices.Add(replacedVector.ConvertToMatrix().MultiplyBy(new HMatrix(1, _m)));

            for (var i = 2; i <= _m; i++)
            {
                wMatrices.Add(wMatrices[i - 2].MultiplyBy(new HMatrix(i, _m)));

            }

            var (index, value) = FindLargestAbsoluteValueInMatrices(wMatrices);
            var decodedVector = ConvertToBinaryReversed(index);

            if (value > 0)
            {
                decodedVector.Insert(0, 1);
                return decodedVector;
            }

            decodedVector.Insert(0, 0);
            return decodedVector;
        }

        private (int Index, int Value) FindLargestAbsoluteValueInMatrices(List<Matrix> matrices)
        {
            var lists = matrices.Select(matrix => matrix.ConvertToList()).ToList();

            var maxAbsoluteValueOfEachList = new List<int>();
            foreach (var list in lists)
            {
                var index = 0;

                for (var i = 1; i < list.Count; i++)
                {
                    index = Math.Abs(list[index]) > Math.Abs(list[i]) ? index : i;
                }

                maxAbsoluteValueOfEachList.Add(list[index]);
            }

            var listIndex = 0;
            for (var i = 1; i < maxAbsoluteValueOfEachList.Count; i++)
            {
                listIndex = Math.Abs(maxAbsoluteValueOfEachList[listIndex]) > Math.Abs(maxAbsoluteValueOfEachList[i]) ? listIndex : i;
            }

            var valueIndex = 0;
            var listWithMaxAbsoluteValue = lists[listIndex];
            for (var i = 1; i < listWithMaxAbsoluteValue.Count; i++)
            {
                valueIndex = Math.Abs(listWithMaxAbsoluteValue[valueIndex]) > Math.Abs(listWithMaxAbsoluteValue[i]) ? valueIndex : i;
            }

            return (valueIndex, listWithMaxAbsoluteValue[valueIndex]);
        }

        private List<int> ConvertToBinaryReversed(int value)
        {
            var bitsString = Convert.ToString(value, 2);
            var countOfZerosToAdd = _m - bitsString.Length - 1;

            for (var i = 0; i <= countOfZerosToAdd; i++)
            {
                bitsString = bitsString.Insert(0, "0");
            }

            var bits = bitsString.ToCharArray().Select(x => int.Parse(x.ToString())).ToList();

            bits.Reverse();

            return bits;
        }
    }
}