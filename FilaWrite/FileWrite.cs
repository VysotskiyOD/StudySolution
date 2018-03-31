using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotifactionSender;
using System.IO;

namespace FileWrite
{
    public class fileWriteMassage : ISender
    {
        public void Send(string Message)
        {
            FileInfo file = new FileInfo(@"C:\test\message.txt");
            if (file.Exists == false) 
            {
                file.Create();
            }
            else
            {
                StreamWriter write_text;
                write_text = file.AppendText();
                write_text.WriteLine(Message); 
                write_text.Close();
            } 
            
         }
    }
}
