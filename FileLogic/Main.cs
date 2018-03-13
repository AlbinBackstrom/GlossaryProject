using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLogic
{
    public class Main
    {
        Thread _MainThread;
        bool _StopFlag = false;
        public void Start()
        {
            try
            {
                if (_MainThread != null)
                {
                    if (_MainThread.ThreadState == System.Threading.ThreadState.Running)
                    {
                        //Debug.WriteLine("Stopping current thread");

                        //Lock to prevent other threads accessing thread 
                        lock (_MainThread)
                        {
                            _MainThread.Abort();
                        }
                    }
                }
                _MainThread = new Thread(Run);
                _StopFlag = false;
                _MainThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error with the XML-service thread. Please restart the program." + ex.Message + ex.InnerException);    
                //Debug.WriteLine(ex.Message);
            }
        }

        private void Run()
        {
            try
            {
                //Debug.WriteLine("File service starting");
                FileChecker fileChecking = new FileChecker(@"C:\Glossary");
                while (_StopFlag != true)
                {
                    fileChecking.readXmlFiles();
                    Thread.Sleep(20000);
                }
            }
            catch (Exception ex)
            {
                //Save exceptions to logfile in the future.
                MessageBox.Show("The XML-service caused an error." + ex.Message + " " + ex.InnerException);
                //Debug.WriteLine(ex.Message);
            }
        }
        public void Stop()
        {
            //Debug.WriteLine("Stopping file service");
            _StopFlag = true;
        }
    }
}
