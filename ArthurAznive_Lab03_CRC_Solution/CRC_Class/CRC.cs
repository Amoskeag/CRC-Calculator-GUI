using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRC_class
{

    public class CRC
    {
        const short POLY = 0x125;
        const byte MASK = 0x80;

        private byte[] _byteArray;   // stores data to receive the CRC calculation
        private byte _crc;
        private byte _remainder;
        private byte _reg;
        private int _length;
        private byte[] _copy;


        public CRC()
        {
            _remainder = 0x0;
        }

        public CRC(char[] anArray) //convert from a character array to byte
        {
            _length = anArray.Length;

            _byteArray = new byte[_length];
            _copy = new byte[_length];

            for (int i = 0; i < _length; i++) //putting the values into the class variable
            {
                _byteArray[i] = Convert.ToByte(anArray[i]);
                _copy[i] = Convert.ToByte(anArray[i]); //using a copy
            }

        }

        public CRC(byte[] anArray)// an array
        {
            _length = anArray.Length;

            _byteArray = new byte[_length];
            _copy = new byte[_length];

            for (int i = 0; i < _length; i++) //putting the values into the class variable
            {
                _byteArray[i] = anArray[i];
                _copy[i] = anArray[i]; //using a copy
            }
        }

        public byte createCRC()
        {
            _reg = (byte)0;

            //for the length of the array, do this.
            for (int i = 0; i < _length; i++)
            {

                for (int b = 0; b < 8; b++)
                {

                    _reg <<= 1; // shift values

                    if ((_copy[i] & MASK) == MASK) // 1 bit found - nothing to do if zero appended
                    {
                        _reg = (byte)(_reg | 1); // 0000 0001
                    }

                    if (_remainder == 1)
                    {
                        _reg = (byte)(_reg ^ POLY);
                        _remainder = (byte)0;
                        _crc = _reg;
                    }


                    if ((_reg & MASK) == MASK)
                    {
                        _remainder = 1;
                    }

                    _copy[i] <<= 1;

                }
            }


            return _reg;
        }


    }
}
