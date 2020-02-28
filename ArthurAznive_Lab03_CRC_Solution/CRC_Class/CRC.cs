/*
 *  HEADER
 *  PROGRAMMER: Arthur W. Aznive Jr.
 *  DATE: 2/20/2020
 *  FILE: CRC_Class 
 *  DESCRIPTION: 
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRC_Class
{

    public class crcClass
    {
        public crcClass()
        {
            //Default Constructor 

        }//End Default Constructor

        //Algorithm constants
        const ushort POLY = 0x125;
        const ushort MASK = 0x80;

        public crcClass(byte[] array)
        {
            // stores data to receive the CRC calculation this is a
            // copy of the original array, but it is not a reference,
            // it is separate from the original with the same data.

            byte[] byteArray = new byte[array.Length];

            //Fill the array. from the original array.
            for( int i = 0; i < array.Length - 1; i++)
            {
                byteArray[i] = array[i];
            }

        }//END crcClass byte Array Constructor


        public byte calcCRC(byte[] byteArray)
        {
            //Returns the calculated CRC value.

            // find CRC 
            for (int i = 0; i < 16; i++)
            {
            }
                return 0;

        }//END CalcCRC
    }
        
}//END Namespace CRC_Class
