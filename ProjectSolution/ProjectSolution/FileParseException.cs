using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class FileParseException: IOException
    {
        string errorMessage;
        string fileName;
        int row;
        Exception exception;
        public FileParseException() 
        {

        }
       
        public FileParseException(string errorMessage, string fileName, int row):this(errorMessage, fileName, row, null )
        {
             
        }
        public FileParseException(string errorMessage, string fileName, int row, Exception exception): base(errorMessage) 
        {
            this.fileName = fileName;
            this.errorMessage = errorMessage;
            this.row = row;
            this.exception = exception;
            
        }
        public string ErrorMessage
        {
            get { return errorMessage; }

        }
        public string FileName
        {

            get { return fileName; }
        }
        public int Row
        {
            get { return row; }
        }

    }
}
