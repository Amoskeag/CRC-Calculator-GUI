/*
 * HEADER 
 * PROGRAMMER: Arthur W. Aznive Jr.
 * DATE: 2/25/2020
 * DESCRIPTION: CRC Code Calculator G.U.I
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRC_Class;

namespace ArthurAznive_Lab03_CRC
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
           
        }

        //Open the File at the specified File location.
        private void openFileBttn_Click(object sender, EventArgs e)
        {
            //open the file explorer and select a .txt file for operation.
            OpenFileDialog openFile = new OpenFileDialog();

            // Initialize the filter to look for text files.
            openFile.Filter = "Text Files|*.txt";

            //If the file is good, lets go
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile.FileName.Length > 0)
            {
                //get the file name for User feedback
                string strFileName = openFile.FileName;

                //set the text box to the PATH
                filePathTxtBox.Text = strFileName;

                //Reads the file in string Array to the richtextboxcontent viewer.
                string[] inputText = File.ReadAllLines(openFile.FileName);
                richTextBoxFileContent.LoadFile(openFile.FileName,
                  RichTextBoxStreamType.PlainText);

            }
        }

        //Calculate the CRC from the input.
        private void calcCRCBtn_Click(object sender, EventArgs e)
        {
            //Check for an input file for operation. yell at user for trying to operate without an input file.
            if (filePathTxtBox.TextLength == 0)
            {
                // error message to user
                MessageBox.Show("The Application requires Text\n\nPlease Open a File",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning // for Warning  
                    //MessageBoxIcon.Error // for Error 
                    //MessageBoxIcon.Information  // for Information
                    //MessageBoxIcon.Question // for Question
                );
            }
            else
            {
                //string to byte array
                String userInput;    // references the user input text string
                
                byte[] byteArray;     // an array of bytes



                // ok to convert from string to byte array and back
                // initalize the aString array and clear inputBox text window
                userInput = richTextBoxFileContent.Text;

                int newLength = userInput.Length + 1;

                // instantiate array 1 byte larger than string size
                byteArray = new byte[newLength];

                // transfer string into byte array using Encoding object
                Encoding.ASCII.GetBytes(userInput, 0, userInput.Length, byteArray, 0);

                //create an instance of the class. with the data.
                crcClass crc = new CRC_Class.crcClass(byteArray);

                //get the crc code.
                byte crcCode = crc.calcCRC(byteArray);

                Console.WriteLine("CRC: {0:X2}", crcCode);

                /*Display

                //decResultTxtBox
                //binaryResultTxtBox
                //hexResultTxtBox
                //octalResultTxtBox

                */

                int _decimal = crcCode; //CRC Code is stored in an integer data type.
                decResultTxtBox.Text = _decimal.ToString(); //convert the int to a string.


                int _hexadecimal = crcCode; //Store the CRC Code in an integer data type.
                hexResultTxtBox.Text = _hexadecimal.ToString("X"); //ToString("X") will convert the int _hexadecimal


                octalResultTxtBox.Text = Convert.ToString(_decimal, 8); //Octal

                



            }

        }
    }
}

