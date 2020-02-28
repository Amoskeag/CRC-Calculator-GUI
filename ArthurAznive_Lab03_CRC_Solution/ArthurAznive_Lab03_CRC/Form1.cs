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
        crcClass crc = new CRC_Class.crcClass();
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
                String inString;    // references the user input text string
                
                byte[] byteArr;     // an array of bytes

                // ok to convert from string to byte array and back
                // initalize the aString array and clear inputBox text window
                inString = richTextBoxFileContent.Text;
                

                // instantiate array 1 byte larger than string size
                byteArr = new byte[inString.Length + 1];

                // transfer string into byte array using Encoding object
                Encoding.ASCII.GetBytes(inString, 0, inString.Length, byteArr, 0);

                crc.calcCRC(byteArr);
                
            }
        }
    }
}

