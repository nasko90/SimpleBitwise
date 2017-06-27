namespace ConsoleApplication1
{
    /// <summary>
    /// Static class containing basic numeric methods and operations
    /// </summary>
    public static class BitwiseOperations
    {
        /// <summary>
        /// Given two integers L and R and find the maximal value of A xor B, where A and B satisfy the following condition: L &lt;= A &lt;= B &lt;= R
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns>Integer - the maximum value of l xor r</returns>
        public static int GetMaxXor(int l, int r)
        {
            var result = 0;
            var xor = l ^ r;
            var positionOfLastUnsignedBit = GetMostSignificantBitPosition(xor);
            for (int i = 0; i <= positionOfLastUnsignedBit; i++)
            {
                result |= 1 << i;
            }

            return result;
        }

        /// <summary>
        /// Find and return the unique element in array where every element in that array occurs exactly twice except for the unique element.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Return the unique element</returns>
        public static int GetUniqueElementInArray(int[] arr)
        {
            var uniqueElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                uniqueElement ^= arr[i];
            }

            return uniqueElement;
        }

        /// <summary>
        /// Get most siginificant bit position in 32bit integer
        /// </summary>
        /// <param name="number">32 bit integer</param>
        /// <returns>The position of most significant bit</returns>
        public static int GetMostSignificantBitPosition(int number)
        {
            int position = 31;
            var firstSignBitPosition = 0;

            while (position >= 0)
            {
                firstSignBitPosition = (number >> position) & 1;
                if (firstSignBitPosition == 1)
                {
                    return position;
                }
                position--;
            }

            return 0;
        }


    }
}
