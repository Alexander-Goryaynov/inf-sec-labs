using System;
using System.IO;
using System.Linq;
using System.Text;

namespace laba2
{
    public class ECB
    {
        private const int blockSize = 128;
        private const int keyShiftLength = 2;
        private const int roundsCount = 16;

        // Начальная перестановка
        private static byte[] IP = {
            58, 50, 42, 34, 26, 18, 10, 2,
            60, 52, 44, 36, 28, 20, 12, 4,
            62, 54, 46, 38, 30, 22, 14, 6,
            64, 56, 48, 40, 32, 24, 16, 8,
            57, 49, 41, 33, 25, 17, 9,  1,
            59, 51, 43, 35, 27, 19, 11, 3,
            61, 53, 45, 37, 29, 21, 13, 5,
            63, 55, 47, 39, 31, 23, 15, 7
        };

        // Конечная перестановка
        private static byte[] FP = {
            40, 8, 48, 16, 56, 24, 64, 32,
            39, 7, 47, 15, 55, 23, 63, 31,
            38, 6, 46, 14, 54, 22, 62, 30,
            37, 5, 45, 13, 53, 21, 61, 29,
            36, 4, 44, 12, 52, 20, 60, 28,
            35, 3, 43, 11, 51, 19, 59, 27,
            34, 2, 42, 10, 50, 18, 58, 26,
            33, 1, 41, 9, 49, 17, 57, 25
        };

        // Функция расширения (Фейстеля)
        private static byte[] ST = {
            32, 1,  2,  3,  4,  5,
            4,  5,  6,  7,  8,  9,
            8,  9,  10, 11, 12, 13,
            12, 13, 14, 15, 16, 17,
            16, 17, 18, 19, 20, 21,
            20, 21, 22, 23, 24, 25,
            24, 25, 26, 27, 28, 29,
            28, 29, 30, 31, 32, 1
        };

        // Таблица подстановок
        private static byte[,] sBox = new byte[,] {
            {14, 4,  13, 1,  2,  15, 11, 8,  3,  10, 6,  12, 5,  9,  0,  7,
            0,  15, 7,  4,  14, 2,  13, 1,  10, 6,  12, 11, 9,  5,  3,  8,
            4,  1,  14, 8,  13, 6,  2,  11, 15, 12, 9,  7,  3,  10, 5,  0,
            15, 12, 8,  2,  4,  9,  1,  7,  5,  11, 3,  14, 10, 0,  6,  13},

            {15, 1,  8,  14, 6,  11, 3,  4,  9,  7,  2,  13, 12, 0,  5,  10,
            3,  13, 4,  7,  15, 2,  8,  14, 12, 0,  1,  10, 6,  9,  11, 5,
            0,  14, 7,  11, 10, 4,  13, 1,  5,  8,  12, 6,  9,  3,  2,  15,
            13, 8,  10, 1,  3,  15, 4,  2,  11, 6,  7,  12, 0,  5,  14, 9},

            {10, 0,  9,  14, 6,  3,  15, 5,  1,  13, 12, 7,  11, 4,  2,  8,
            13, 7,  0,  9,  3,  4,  6,  10, 2,  8,  5,  14, 12, 11, 15, 1,
            13, 6,  4,  9,  8,  15, 3,  0,  11, 1,  2,  12, 5,  10, 14, 7,
            1,  10, 13, 0,  6,  9,  8,  7,  4,  15, 14, 3,  11, 5,  2,  12},

            {7,  13, 14, 3,  0,  6,  9,  10, 1,  2,  8,  5,  11, 12, 4,  15,
            13, 8,  11, 5,  6,  15, 0,  3,  4,  7,  2,  12, 1,  10, 14, 9,
            10, 6,  9,  0,  12, 11, 7,  13, 15, 1,  3,  14, 5,  2,  8,  4,
            3,  15, 0,  6,  10, 1,  13, 8,  9,  4,  5,  11, 12, 7,  2,  14},

            {2,  12, 4,  1,  7,  10, 11, 6,  8,  5,  3,  15, 13, 0,  14, 9,
            14, 11, 2,  12, 4,  7,  13, 1,  5,  0,  15, 10, 3,  9,  8,  6,
            4,  2,  1,  11, 10, 13, 7,  8,  15, 9,  12, 5,  6,  3,  0,  14,
            11, 8,  12, 7,  1,  14, 2,  13, 6,  15, 0,  9,  10, 4,  5,  3},

            {12, 1,  10, 15, 9,  2,  6,  8,  0,  13, 3,  4,  14, 7,  5,  11,
            10, 15, 4,  2,  7,  12, 9,  5,  6,  1,  13, 14, 0,  11, 3,  8,
            9,  14, 15, 5,  2,  8,  12, 3,  7,  0,  4,  10, 1,  13, 11, 6,
            4,  3,  2,  12, 9,  5,  15, 10, 11, 14, 1,  7,  6,  0,  8,  13},

            {4,  11, 2,  14, 15, 0,  8,  13, 3,  12, 9,  7,  5,  10, 6,  1,
            13, 0,  11, 7,  4,  9,  1,  10, 14, 3,  5,  12, 2,  15, 8,  6,
            1,  4,  11, 13, 12, 3,  7,  14, 10, 15, 6,  8,  0,  5,  9,  2,
            6,  11, 13, 8,  1,  4,  10, 7,  9,  5,  0,  15, 14, 2,  3,  12},

            {13, 2,  8,  4,  6,  15, 11, 1,  10, 9,  3,  14, 5,  0,  12, 7,
            1,  15, 13, 8,  10, 3,  7,  4,  12, 5,  6,  11, 0,  14, 9,  2,
            7,  11, 4,  1,  9,  12, 14, 2,  0,  6,  10, 13, 15, 3,  5,  8,
            2,  1,  14, 7,  4,  10, 8,  13, 15, 12, 9,  0,  3,  5,  6,  11}
        };

        private byte[][] blocks;

        public void Encrypt(string sourceFileName, string targetFileName, string key)
        {
            byte[] source = File.ReadAllBytes(sourceFileName);
            source = PadToBlockLength(source);
            SplitIntoBlocks(source);
            foreach (var block in blocks)
            {
                MakeInitialPermutation(block);
            }
            key = CorrectKeyWord(key, source.Length / (2 * blocks.Length));
            byte[] keyBytes = Encoding.ASCII.GetBytes(key);
            for (int j = 0; j < roundsCount; j++)
            {
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i] = MakeDesEncodingRound(blocks[i], keyBytes);
                }
                key = KeyToNextRound(key);
                keyBytes = Encoding.ASCII.GetBytes(key);
            }
            byte[] result = new byte[] { };
            for (int i = 0; i < blocks.Length; i++)
            {
                result = result.Concat(blocks[i]).ToArray();
            }
            MakeFinalPermutation(result);
            File.WriteAllBytes(targetFileName, result);
        }

        public void Decrypt(string sourceFileName, string targetFileName, string key)
        {
            byte[] source = File.ReadAllBytes(sourceFileName);
            SplitIntoBlocks(source);
            key = CorrectKeyWord(key, source.Length / (2 * blocks.Length));
            for (int j = 0; j < roundsCount; j++)
            {
                key = KeyToNextRound(key);
            }
            key = KeyToPrevRound(key);
            byte[] keyBytes = Encoding.ASCII.GetBytes(key);
            for (int j = 0; j < roundsCount; j++)
            {
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i] = MakeDesDecodingRound(blocks[i], keyBytes);
                }
                key = KeyToPrevRound(key);
                keyBytes = Encoding.ASCII.GetBytes(key);
            }
            byte[] result = new byte[] { };
            for (int i = 0; i < blocks.Length; i++)
            {
                result = result.Concat(blocks[i]).ToArray();
            }
            File.WriteAllBytes(targetFileName, result);
        }

        private byte[] PadToBlockLength(byte[] input)
        {
            while (input.Length % blockSize != 0)
            {
                input = input.Concat(new byte[] { 0 }).ToArray();
            }
            return input;
        }

        private void SplitIntoBlocks(byte[] input)
        {
            blocks = new byte[input.Length / blockSize][];
            int lengthOfBlock = input.Length / blocks.Length;
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new byte[blockSize];
                Array.Copy(input, i * lengthOfBlock, blocks[i], 0, lengthOfBlock);
            }
        }

        private string CorrectKeyWord(string input, int lengthKey)
        {
            if (input.Length > lengthKey)
            {
                input = input.Substring(0, lengthKey);
            }
            else
            {
                while (input.Length < lengthKey)
                {
                    input = "0" + input;
                }
            }
            return input;
        }

        private void MakeInitialPermutation(byte[] input)
        {
            byte[] result = new byte[input.Length];
            for (int i = 0; i < 64; i++)
            {
                result[i] = input[IP[i] - 1];
            }
        }

        private void MakeFinalPermutation(byte[] output)
        {
            byte[] result = new byte[output.Length];
            for (int i = 0; i < 64; i++)
            {
                result[i] = output[FP[i] - 1];
            }
        }

        private byte[] MakeDesEncodingRound(byte[] input, byte[] key)
        {
            byte[] l = new byte[input.Length / 2];
            byte[] r = new byte[input.Length / 2];
            Array.Copy(input, 0, l, 0, input.Length / 2);
            Array.Copy(input, input.Length / 2, r, 0, input.Length / 2);
            return r.Concat(XOR(l, f(r, key))).ToArray();
        }

        private byte[] MakeDesDecodingRound(byte[] input, byte[] key)
        {
            byte[] l = new byte[input.Length / 2];
            byte[] r = new byte[input.Length / 2];
            Array.Copy(input, 0, l, 0, input.Length / 2);
            Array.Copy(input, input.Length / 2, r, 0, input.Length / 2);
            return XOR(f(l, key), r).Concat(l).ToArray();
        }

        private byte[] XOR(byte[] s1, byte[] s2)
        {
            byte[] result = new byte[] { };
            for (int i = 0; i < s1.Length; i++)
            {
                result = result.Concat(new byte[] { (byte)(s1[i] ^ s2[i]) }).ToArray();
            }
            return result;
        }

        private byte[] f(byte[] s1, byte[] s2)
        {
            int[] e = new int[48];
            for (int i = 0; i < 48; i++)
            {
                e[i] = e[ST[i] - 1];
            }
            TransformViaSBox(s1);
            TransformViaSBox(s2);
            return XOR(s1, s2);
        }

        private string KeyToNextRound(string key)
        {
            for (int i = 0; i < keyShiftLength; i++)
            {
                key = key[key.Length - 1] + key;
                key = key.Remove(key.Length - 1);
            }

            return key;
        }

        private string KeyToPrevRound(string key)
        {
            for (int i = 0; i < keyShiftLength; i++)
            {
                key += key[0];
                key = key.Remove(0, 1);
            }
            return key;
        }

        private static void TransformViaSBox(byte[] input)
        {
            byte[] output = new byte[32];
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    byte[] row = new byte[2];
                    row[0] = input[6 * i];
                    row[1] = input[(6 * i) + 5];
                    String sRow = row[0] + "" + row[1];
                    byte[] column = new byte[4];
                    column[0] = input[(6 * i) + 1];
                    column[1] = input[(6 * i) + 2];
                    column[2] = input[(6 * i) + 3];
                    column[3] = input[(6 * i) + 4];
                    String sColumn = column[0] + "" + column[1] + "" + column[2] + "" + column[3];
                    byte iRow = Byte.Parse(sRow);
                    byte iColumn = Byte.Parse(sColumn);
                    byte x = sBox[i, (iRow * 16) + iColumn];
                    String s = Convert.ToString(x);
                    while (s.Length < 4)
                    {
                        s = "0" + s;
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        output[(i * 4) + j] = Byte.Parse(s[j] + "");
                    }
                }
                byte[] finalOutput = new byte[32];
                for (int i = 0; i < finalOutput.Length; i++)
                {
                    finalOutput[i] = output[sBox[i, i] - 1];
                }
            } catch (Exception) { }            
        }
    }
}
